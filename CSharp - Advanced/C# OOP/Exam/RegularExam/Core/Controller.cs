using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Repositories.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core;

public class Controller : IController
{

    private RobotRepository robots;
    private SupplementRepository supplements;

    public Controller()
    {
        robots = new RobotRepository();
        supplements = new SupplementRepository();
    }
    public string CreateRobot(string model, string typeName)
    {
        if (typeName != nameof(DomesticAssistant) && typeName != nameof(IndustrialAssistant))
        {
            return string.Format(OutputMessages.RobotCannotBeCreated, typeName);
        }

        IRobot robot = null;

        if (typeName == nameof(DomesticAssistant))
        {
            robot = new DomesticAssistant(model);
        }
        else
        {
            robot = new IndustrialAssistant(model);
        }

        robots.AddNew(robot);

        return string.Format(OutputMessages.RobotCreatedSuccessfully, typeName, model);
    }

    public string CreateSupplement(string typeName)
    {
        if (typeName != nameof(SpecializedArm) && typeName != nameof(LaserRadar))
        {
            return string.Format(OutputMessages.SupplementCannotBeCreated, typeName);
        }

        ISupplement supplement = null;

        if (typeName == nameof(SpecializedArm))
        {
            supplement = new SpecializedArm();
        }
        else
        {
            supplement = new LaserRadar();
        }

        supplements.AddNew(supplement);

        return string.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);
    }
    public string UpgradeRobot(string model, string supplementTypeName)
    {
        ISupplement supplement = supplements.Models().FirstOrDefault(x => x.GetType().Name == supplementTypeName);

        List<IRobot> robotsA = new List<IRobot>();

        foreach (var robotA in robots.Models().Where(r => r.Model == model))
        {
            if (!robotA.InterfaceStandards.Contains(supplement.InterfaceStandard))
            {
                robotsA.Add(robotA);
            }
        }

        if (robotsA.Count == 0)
        {
            return string.Format(OutputMessages.AllModelsUpgraded, model);
        }

        IRobot robot = robotsA[0];

        robot.InstallSupplement(supplement);
        supplements.RemoveByName(supplementTypeName);

        return string.Format(OutputMessages.UpgradeSuccessful, model, supplementTypeName);

    }

    public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
    {

        List<IRobot> robotsA = robots.Models().Where(r => r.InterfaceStandards.Contains(intefaceStandard)).ToList();

        if (robotsA.Count == 0)
        {
            return string.Format(OutputMessages.UnableToPerform, intefaceStandard);
        }

        List<IRobot> sortedRobots = robotsA.OrderByDescending(r => r.BatteryLevel).ToList();

        int batterySum = sortedRobots.Sum(r => r.BatteryLevel);

        if (batterySum < totalPowerNeeded)
        {
            return string.Format(OutputMessages.MorePowerNeeded, serviceName, totalPowerNeeded - batterySum);
        }


        int counter = 0;

        foreach (var robot in sortedRobots)
        {
            if (robot.BatteryLevel >= totalPowerNeeded)
            {
                robot.ExecuteService(totalPowerNeeded);
                counter++;
                break;
            }
            else
            {
                totalPowerNeeded -= robot.BatteryLevel;
                robot.ExecuteService(robot.BatteryLevel);
                counter++;
            }
        }

        return string.Format(OutputMessages.PerformedSuccessfully, serviceName, counter);


    }
    public string RobotRecovery(string model, int minutes)
    {
        int counter = 0;

        foreach (var robot in robots.Models().Where(r => r.BatteryLevel < r.BatteryCapacity / 2 && r.Model == model))
        {
            robot.Eating(minutes);
            counter++;
        }

        return string.Format(OutputMessages.RobotsFed, counter);
    }

    public string Report()
    {
        var orderdRobots = robots.Models().OrderByDescending(r => r.BatteryLevel).ThenBy(r => r.BatteryCapacity);

        StringBuilder sb = new StringBuilder();

        foreach (var robot in orderdRobots)
        {
            sb.AppendLine(robot.ToString());
        }

        return sb.ToString().Trim();

    }
}

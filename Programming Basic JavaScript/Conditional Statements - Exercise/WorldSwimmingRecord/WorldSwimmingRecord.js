function worldSwimmingRecord(input)
{
    let recordInSeconds = Number(input.shift());
    let distanceInMeters = Number(input.shift());
    let timeInSec = Number(input.shift());

    let neededDistance = distanceInMeters * timeInSec;

    let every15Meters = (Math.floor(distanceInMeters / 15)) * 12.5;

    let sumTime = Math.abs(neededDistance + every15Meters);

    if(recordInSeconds > sumTime)
    {
        let toralNewRecord = neededDistance + every15Meters;
        console.log(`Yes, he succeeded! The new world record is ${toralNewRecord.toFixed(2)} seconds.`);
    }
    else if(recordInSeconds <= sumTime)
    {
        let totalTimeSlower = sumTime - recordInSeconds;
        console.log(`No, he failed! He was ${totalTimeSlower.toFixed(2)} seconds slower.`);
    }
}

worldSwimmingRecord(["10464",
"1500",
"20"])

worldSwimmingRecord(["55555.67",
"3017",
"5.03"])


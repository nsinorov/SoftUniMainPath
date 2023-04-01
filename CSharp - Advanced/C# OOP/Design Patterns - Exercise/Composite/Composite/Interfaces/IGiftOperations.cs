
using Composite.Models;

namespace Composite.Interfaces;
public interface IGiftOperations
{
    void Add(GiftBase gift);
    void Remove(GiftBase gift);
}

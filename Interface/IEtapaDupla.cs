
namespace Pipeline.Interface
{
    public interface IEtapaDupla<T> : IEtapa<T>
    {
        IEtapaDupla<T> ProximaEtapa { get; set; }
    }
}

namespace Pipeline.Interface
{
    public interface IEtapa<T>
    {
        T Processar(T entrada);
    }
}
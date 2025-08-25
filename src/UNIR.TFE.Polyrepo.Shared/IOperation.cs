namespace UNIR.TFE.Polyrepo.Shared
{
    public interface IOperation
    {
        string Key { get; }
        decimal Execute(decimal a, decimal b);
    }
}



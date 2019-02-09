public interface ISpecification<in TEntity>
{
    IEnumerable<string> ReasonsForDissatisfaction { get; }
    bool IsSatisfiedBy(TEntity entity);
}

public class BusinessIdSpecification(string id_1) : ISpecification<String> {

    public IEnumerable<string> ReasonsForDissatisfaction { get; }
    public ISpecification(TEntity entity)
    {
        string id = BusinessID.ID_value;

    }
}
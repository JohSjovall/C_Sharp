public interface ISpecification<in TEntity>
{
    IEnumerable<string> ReasonsForDissatisfaction { get; }
    bool IsSatisfiedBy(TEntity entity);
}
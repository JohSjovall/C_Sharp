public class BusinessIdSpecification : ISpecification<String> {

    private string[] id_list = {"kokeilaan","miten","toimii"};

    public BusinessIdSpecification (string[] test_id_list){

        string[] incorect_id;

        for (int i = 0; i < test_id_list.Length; i++)
        {
            string[] list = {test_id_list[i], id_list[i]}
            if (!ISpecification(list))
            {
                incorect_id.add(list[i]);
                Console.WriteLine("incorect");
            }
        }
        int sum = 0;
        foreach (string[] incorect_id in ReasonsForDissatisfaction)
        {
            Console.WriteLine(incorect_id[sum]);
            sum++;
        }
        return ReasonsForDissatisfaction;
    }
    public IEnumerable<string> ReasonsForDissatisfaction
    {
        get => _ReasonsForDissatisfaction;
    }

    public ISpecification(TEntity entity)
    {
        if(entity[0] == entity[1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class app
{
    static void Main()
    {
        string[] id_list = { "kokeilaan", "mita", "toimii" };
        BusinessIdSpecification(id_list);
    }
}
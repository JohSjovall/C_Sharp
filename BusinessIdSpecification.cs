using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cgi
{
    using System;
    namespace BusinessIdSpecification
    {

        public interface ISpecification<in TEntity>
        {
            IEnumerable<string> ReasonsForDissatisfaction { get; }
            bool IsSatisfiedBy(TEntity entity);
        }

        public class BusinessIdSpecification<TEntity> : ISpecification<TEntity>
        {

            public string[] fail = null;
            private string id = "testi";

            public IEnumerable<string> ReasonsForDissatisfaction
            {
                get;
                private set;
            }

            public void Setlist(string[] list)
            {
                ReasonsForDissatisfaction = list;
            }

            public bool IsSatisfiedBy(TEntity entity)
            { 
                if(entity.Equals(id))
                {
                    Console.WriteLine("True");
                    Console.WriteLine(entity.ToString());
                    return true;
                }
                else
                {
                    Console.WriteLine("False");
                    string value = entity.ToString();
                    if(value.Length == id.Length)
                    {
                        string[] fail = new string[value.Length];
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (value[i].Equals(id[i]))
                            {
                                fail[i] = null;
                            }
                            else
                            {
                                fail[i] = value[i].ToString();
                                Console.WriteLine(value[i].ToString());
                            }
                        }
                    }
                    if (value.Length > id.Length)
                    {
                        string[] fail = new string[value.Length];
                        for (int i = 0; i < value.Length; i++)
                        {
                            if(i<id.Length)
                            {
                                if (value[i].Equals(id[i]))
                                {
                                    fail[i] = null;
                                }
                                else
                                {
                                    fail[i] = value[i].ToString();
                                    Console.WriteLine(value[i].ToString());
                                }
                            }
                            else
                            {
                                fail[i] = value[i].ToString();
                                Console.WriteLine(value[i].ToString());
                            }
                        }
                    }

                    if (value.Length < id.Length)
                    {
                        string[] fail = new string[id.Length];
                        for (int i = 0; i < id.Length; i++)
                        {
                            if (i < value.Length)
                            {
                                if (value[i].Equals(id[i]))
                                {
                                    fail[i] = null;
                                }
                                else
                                {
                                    fail[i] = value[i].ToString();
                                }
                            }
                            else
                            {
                                fail[i] = "#";
                                Console.WriteLine("#");
                            }
                        }
                    }
                    ReasonsForDissatisfaction = fail;
                    return false;
                }
            }
        }
        public class testaus
        {
            static void Main()
            {
                string tunnus = "kk";
                BusinessIdSpecification<string> testi = new BusinessIdSpecification<string>();
                testi.IsSatisfiedBy(id);
                string[] virheet = testi.ReasonsForDissatisfaction.ToArray();
                Console.ReadLine();
            }
        }
    }
}
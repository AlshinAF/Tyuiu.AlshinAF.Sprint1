using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AlshinAF.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {
            string[] s = value.Split(' ');
            for (int i = 0; i < s.Length; i++)
                value = s[i].Substring(1) + " ";
            return value;
        }
    }
}

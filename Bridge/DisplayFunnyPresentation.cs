using System.Text;

public class DisplayFunnyPresentation : IDisplayPresentation
{

    public string GetHeader(string name)
    {
        var dataHeader = new StringBuilder();
        dataHeader.Append("My " + name);
        dataHeader.AppendLine();        

        return FunnyRandom(dataHeader.ToString());
        
    }

    public string GetContent(string data)
    {
        var dataContent = new StringBuilder();
        dataContent.Append(data);
        dataContent.AppendLine();
        dataContent.Append("date: " + DateTime.Now.ToShortDateString());
        return FunnyRandom(dataContent.ToString()) + " haha wasUpppp";
    }

    string FunnyRandom(string data)
    {
        var random = new Random();
        var chars = data.ToCharArray();
    
        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = random.Next(2) == 0 
                ? char.ToLower(chars[i]) 
                : char.ToUpper(chars[i]);
        }    
        return new string(chars).ToString();
    }
}
const string filepath = "book.txt";

List<string> text = await ReadFileAsync(filepath);
if(text == null || text.Count == 0)
    return;

SortString(text);

foreach(string line in text)
    Console.WriteLine(line);


async Task<List<string>> ReadFileAsync(string filepath)
{
    if (!File.Exists(filepath))
        throw new FileNotFoundException();
    List<string> result = new List<string>();
    using (StreamReader reader = new StreamReader(filepath))
    {
        string? line;
        while ((line = await reader.ReadLineAsync()) != null)
        {
            if (line == null || line == string.Empty)
                return result;
            result.Add(line);
        }
    }
    return result;
}

void SortString(List<string> inputList)
{
    string temp = string.Empty;

    for (int i = 0; i < inputList.Count; i++)
    {
        for (int j = 0; j < inputList.Count - 1; j++)
        {

            if (inputList[j].CompareTo(inputList[j + 1]) > 0)
            {
                temp = inputList[j];
                inputList[j] = inputList[j + 1];
                inputList[j + 1] = temp;
            }
        }
    }
        
}
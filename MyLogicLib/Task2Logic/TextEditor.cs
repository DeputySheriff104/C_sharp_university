namespace MyLogicLib.Task2Logic
{
    public class TextEditor
    {
        private string[] NumbersFileStringArr { get; set; }

        private string[] TextFileStringArr { get; set; }

        public TextEditor(string[] numbersFileStringArr, string[] textFileStringArr)
        {
            NumbersFileStringArr = numbersFileStringArr;
            TextFileStringArr = textFileStringArr;
        }

        public string[] GetNewTextFile(bool addToLeft, bool addToRight)
        {
            string[] newTextFile = new string[TextFileStringArr.Length];
            for (int i = 0; i < TextFileStringArr.Length; i++)
            {
                if (i < NumbersFileStringArr.Length)
                {
                    if (addToLeft && addToRight)
                    {
                        newTextFile[i] = string.Format(
                            "{1} {0} {1}", TextFileStringArr[i], NumbersFileStringArr[i]);
                    } 
                    else
                    if (addToLeft)
                    {
                        newTextFile[i] = string.Format(
                            "{1} {0}", TextFileStringArr[i], NumbersFileStringArr[i]);
                    } 
                    else
                    if (addToRight)
                    {
                        newTextFile[i] = string.Format(
                            "{0} {1}", TextFileStringArr[i], NumbersFileStringArr[i]);
                    }
                }
                else
                {
                    newTextFile[i] = TextFileStringArr[i];
                }
            }
            return newTextFile;
        }
    }
}
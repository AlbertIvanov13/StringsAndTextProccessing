
string bigNumber = Console.ReadLine();
string digit =  Console.ReadLine();

int carry = 0;
List<string> result = new List<string>();
if (digit == "0")
{
    result.Add("0");
}
else
{
    for (int i = bigNumber.Length - 1; i >= 0; i--)
    {
        int newResult = int.Parse(bigNumber[i].ToString()) * int.Parse(digit.ToString()) + carry;

        string newResultt = newResult.ToString();

        for (int j = 0; j < newResultt.Length; j++)
        {
            result.Add(newResultt[newResultt.Length - 1].ToString());
            carry = newResult / 10;
            break;
        }
    }
}

result.Reverse();
if (carry > 0)
{
   Console.Write(carry);
}
Console.WriteLine(string.Join("", result));
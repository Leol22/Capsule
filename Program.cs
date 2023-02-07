using Capsule;
gridmath conversion = new gridmath();
string path = @$"./{args[0]}";
string[] code = File.ReadAllLines(path);
int[,] grid = { { 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, }, { 0, 0, 0, 0, 0, 0, 0, 0, }, };
List<int> stack1 = new List<int>();
List<int> stack2 = new List<int>();
List<int> marks = new List<int>();
int output = 0;
bool active = true;
int step = 0;
bool test = false;
bool intype=false;
string[] inputs;
string secondpath = path;
int charcounter = 0;
if (args.Length > 1) { intype = true; secondpath = @$"./{args[1]}"; }
inputs = File.ReadAllLines(secondpath);
int lastread = 0;
foreach(string line in code)
{
if (line == "M") { marks.Add(step); }
    step++;

}
step = 0;
while (active)
{
    if (code[step] == "OM") { output = (output - 1) * -1; if (output == 0) { Console.Write("\n"); } }
    if (code[step].Length == 3)
    {

        conversion.Input = code[step].Substring(1, 2);
        if (code[step][0] == 'O')
        {
            if (output == 0)
            {
                Console.WriteLine(grid[conversion.SelfX(), conversion.SelfY()]);
            }
            else { Console.Write((char)(grid[conversion.SelfX(), conversion.SelfY()])); }
        }
        if (code[step][0] == 'I')
        {
            if (intype == false)
            {
                Console.Write("Input:");
                if (output == 0)
                {
                    grid[conversion.SelfX(), conversion.SelfY()] = int.Parse(Console.ReadLine());
                }
                else { grid[conversion.SelfX(), conversion.SelfY()] = ((byte)Console.ReadLine()[0]); }
            }
            else
            {
                if (output == 0)
                {
                    if (charcounter > 0) { charcounter = 0;lastread++; };
                    grid[conversion.SelfX(), conversion.SelfY()] = int.Parse(inputs[lastread]); lastread++;
                }
                else { grid[conversion.SelfX(), conversion.SelfY()] = ((byte)inputs[lastread][charcounter]); charcounter++; if (charcounter == inputs[lastread].Length) { charcounter = 0;lastread++ ; } }

            }
        }

        if (code[step][0] == '+')
        {

            grid[conversion.SelfX(), conversion.SelfY()]++;
        }
        if (code[step][0] == '-')
        {

            grid[conversion.SelfX(), conversion.SelfY()]--;
        }
        if (code[step][0] == 'F')
        {

            grid[conversion.SelfX(), conversion.SelfY()] = 0 - grid[conversion.SelfX(), conversion.SelfY()];
        }
    }

    if (code[step].Length == 4)
    {


        if (code[step] == "ENDP") { active = false; }
            conversion.Input = code[step].Substring(0, 2);
        conversion.Direction = code[step].Substring(3, 1);

            if (code[step][2] == '>')
            {
                grid[conversion.SwitchX(), conversion.SwitchY()] = grid[conversion.SelfX(),conversion.SelfY()];
        }

        if (code[step][3] == '1')
        {
            if (code[step][2] == 'S') { stack1.Add(grid[conversion.SelfX(),conversion.SelfY()]); }
            if (code[step][2] == 'G') { grid[conversion.SelfX(), conversion.SelfY()] = stack1[stack1.Count-1];stack1.RemoveAt(stack1.Count - 1); }
            if (code[step][2] == 'L') { grid[conversion.SelfX(), conversion.SelfY()] = stack1.Count; }
        }
        if (code[step][3] == '2')
        {
            if (code[step][2] == 'S') { stack2.Add(grid[conversion.SelfX(), conversion.SelfY()]); }
            if (code[step][2] == 'G') { grid[conversion.SelfX(), conversion.SelfY()] = stack2[stack2.Count-1]; stack2.RemoveAt(stack2.Count - 1); }
            if (code[step][2] == 'L') { grid[conversion.SelfX(), conversion.SelfY()] = stack2.Count; }
        }




    }
    if (code[step].Length == 5)
    {
        conversion.Input = code[step].Substring(0, 2);
        conversion.Direction = code[step].Substring(4, 1);
        string temp = code[step].Substring(2,2);
        if (temp == "+>")
        {
            grid[conversion.SwitchX(), conversion.SwitchY()] = grid[conversion.SwitchX(), conversion.SwitchY()] + grid[conversion.SelfX(), conversion.SelfY()];
            grid[conversion.SelfX(), conversion.SelfY()] = 0;

        }
        if (temp == "=>")
        {
            grid[conversion.SwitchX(), conversion.SwitchY()] = grid[conversion.SelfX(), conversion.SelfY()];
            grid[conversion.SelfX(), conversion.SelfY()] = 0;

        }

        if (temp == "><")
        {
            int tempo = grid[conversion.SwitchX(), conversion.SwitchY()];
            grid[conversion.SwitchX(), conversion.SwitchY()] = grid[conversion.SelfX(), conversion.SelfY()];
            grid[conversion.SelfX(), conversion.SelfY()] = tempo;

        }
        if (temp == "==")
        {
        if (grid[conversion.SwitchX(), conversion.SwitchY()] == grid[conversion.SelfX(), conversion.SelfY()]) { test = true; }
            else {test=false; }

        }
        if (temp == "<<")
        {
            if (grid[conversion.SwitchX(), conversion.SwitchY()] > grid[conversion.SelfX(), conversion.SelfY()]) { test = true; }
            else { test = false; }

        }
        if (temp == ">>")
        {
            if (grid[conversion.SwitchX(), conversion.SwitchY()] < grid[conversion.SelfX(), conversion.SelfY()]) { test = true; }
            else { test = false; }

        }

    }
    if (code[step].Length == 6)
    {
        if (code[step].Substring(4, 2) == "TJ" && test) { step = marks[int.Parse(code[step].Substring(0, 4))]; }
        else
        {
            if (code[step].Substring(4, 2) == "FJ" && (test == false)) { step = marks[int.Parse(code[step].Substring(0, 4))]; }
            else { if (code[step].Substring(4, 2) == "AJ") { step = marks[int.Parse(code[step].Substring(0, 4))]; } }
        }
    }
    //step
    step++;
    if (step == code.Count()) { step = 0; }
}

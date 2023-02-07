namespace Capsule
{
    public class gridmath
    {
        public string Input{ get; set; } = "A1";
        public string Direction { get; set; } = "U";
    
    public int SelfX() {
        switch (Input[0]){

                case 'A': return 0;
                case 'B': return 1;
                case 'C': return 2;
                case 'D': return 3;
                case 'E': return 4;
                case 'F': return 5;
                case 'G': return 6;
                case 'H': return 7;
                default:return 8;

            }

      
      }


    public int SwitchX() { 
        int local=SelfX();
        if (Direction=="U")
            { local--; }
        if (Direction == "D")
        { local++; }
   if (local < 0) { local = 7; }
   if (local > 7) { local = 0; }
   return local;
        }
        public int SelfY() { return int.Parse(Input[1].ToString())-1; }
        
    public int SwitchY() {
            int local = int.Parse(Input[1].ToString())-1;
            if (Direction == "L")
            { local--; }
            if (Direction == "R")
            { local++; }
            if (local < 0) { local = 7; }
            if (local > 7) { local = 0; }
            return local;


        }
    }

}

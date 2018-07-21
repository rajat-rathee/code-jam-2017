using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static System.Environment;
using System.Text.RegularExpressions;
namespace A 
{
class oversizedpancakeflipper {
    static void Main(string[] args){
        List<string> input = new List<string>();
        List<string> inputk = new List<string>();
        List<string> inputs = new List<string>();


        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;
            while((line=reader.ReadLine()) != null) {
                input.Add(line);
                inputs.Add(line);
            }
        }
        inputk = input;
        for (int x=0; x<inputk.Count; x++){
            string delete = inputk[x].Trim('-','+',' ');
            //Console.WriteLine(delete);
            inputk[x] = delete;
        }

        for (int l = 0; l<inputs.Count; l++){
            string replace = inputs[l].Trim('0','1','2','3','4','5','6','7','8','9',' ');
           // //Console.WriteLine(replace);
            inputs[l] = replace;
        }
        //inputs.ForEach(Console.WriteLine);
        //foreach(string l in inputs){
         //   string replace = Regex.Replace(inputs[trial], @"[\d-]", string.Empty);
           // Console.WriteLine(replace);
      //      inputs[x] = replace;
      //  }
        
        bool solution = false;
        bool impossible= false; //out
        
        string s;
        int flips = 0; //out
        int t = int.Parse(input[0]);
        int k;
    for(int i=1;i<=t;i++){
        flips = 0;
        s = inputs[i];
        k = int.Parse(inputk[i]);
        while(solution == false && impossible == false){
            if(s.Length < k){
                impossible = true;
            }
            solution = true;
            for(int l = 0; l < s.Length; l++){
                if(s.Substring(l,1) != "+"){
                    solution = false;
                }
                //Console.WriteLine(s.Substring(l,1));
            }
            if(s[0] == '+') {
                s = s.Substring(1);
                //Console.WriteLine(s.Substring(1));
            }else {
                flips++;
                if(s.Length < k){
                impossible = true;
                }else {
               // Console.WriteLine(flips);
                for(int j = 0; j<=k-1;j++) {
                    if(s.Substring(j,1) == "+"){
                        if(j == 0) {
                            s = "-" + s.Substring(1);
                        }else{
                             s = s.Substring(0,j) + "-" + s.Substring(j+1);
                        }
                    } else {
                        if(j == 0) {
                            s = "+" + s.Substring(1);
                        }else{
                             s = s.Substring(0,j) + "+" + s.Substring(j+1);
                        }
                    }
                }
                }
            }
        }
        if(impossible == true){
            Console.WriteLine("Case #" + i + ": IMPOSSIBLE");
        } else {
            Console.WriteLine("Case #" + i + ": " + flips);
        }
        impossible = false;
        solution = false;
    }

}
}
}
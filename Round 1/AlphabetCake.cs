using System;
using System.Collections.Generic;
using System.IO;
class AlphabetCake{
    static void Main(string[] args){
        bool solution = false;
        List<string> norm = new List<string>();

        using (StreamReader reader = new StreamReader("input.txt")) {
            string line;
            while((line = reader.ReadLine()) != null){
                norm.Add(line);
            }
        }
         
         
         for (int k=0; k<norm.Count; k++){
           string l = norm[k];
           norm[k] =  l.Replace(' ', '\n');
             
         }
           // norm.ForEach(Console.WriteLine);
            int t = (int.Parse(norm[0]));
            int row = (int.Parse(norm[1]));
            int col = (int.Parse(norm[2]));
            while(t>0){
                for(int i=1;i<=t;i++){
                    row = (int.Parse(norm[2*i-1]));
                    col = (int.Parse(norm[2*i]));
                    while(solution == false){
                        char[,] array = new char[row, col];
                        char[,] changed = new char[rc, cc];

                        var input = norm[col+1].Split(new [] { '\n' });
                        int r = 0;
                        
                        foreach (string x in input){
                            int c = 0;
                            foreach(char character in x){
                        array[r,c] = character;
                        c++;
                    }
                    r++;
                }
                bool solve = false;
                if(solve == false)
                for(int h=0;h<row;h++){
                    for(int j=0; j<col;j++){
                        char v = array[h,j];
                        bool IsEnglishLetter(v)){
                            return (v>='A' && v<='Z');
                        }
                        if(array[h,j] = changed[h,j]){
                            j++;
                            so
                        }
                        if(IsEnglishLetter){
                            if()
                        }
                    }
                }
                
                
                
            }
            Console.WriteLine("Case #" + i + ": " +  '\n');
            }
            }

    }
}

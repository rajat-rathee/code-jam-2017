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
        List<string> changed = new List<string>();
        List<int> food11 = new List<int>();
        List<int> food22 = new List<int>();
        int linenum = 0;
        int t = 100;
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;
            while((line=reader.ReadLine()) != null) {
                if(linenum == 0){
                    t = int.Parse(line);
                } else if(linenum % 3 == 1) {
                    input.Add(line);
                } else if(linenum % 3 == 2) {
                    food11.Add(int.Parse(line));
                } else {
                    food22.Add(int.Parse(line));
                }
                linenum++;
            }
        }
        for (int k=0; k<input.Count; k++){
           string l = input[k];
           input[k] =  l.Replace(' ', '\n');
        }
        string[] fix = input.ToArray();
        System.IO.File.WriteAllLines("input.txt", fix);
        
        using (StreamReader reader2 = new StreamReader("input.txt")) {
            string line2;
            while((line2 = reader2.ReadLine()) != null){
                changed.Add(line2);
            }
        }
        for(int i = 0; i < changed.Count;i++){
            if(i % 2 == 0){
                food11.Add(int.Parse(changed[i]));
            }else{
                food22.Add(int.Parse(changed[i]));
            }
            
        }
        int food1;
        int food2;
        int sampleFood1 = 0;
        int sampleFood2 = 0;
        int servings = 0;
        int j = 1;
        bool solution = false;
        for(int i = 0;i < t;i++){
            j = i + 1;
            servings = 0;
            int pworiwo = i-1;
            int yhuiwgsyufgds = i-1;
            food1 = food11[yhuiwgsyufgds];
            food2 = food22[pworiwo];
            while(sampleFood1 >= sampleFood1*1.1 && solution == false){
                servings++;
                if(food1 <= sampleFood1*1.1 && food1 >= sampleFood1){
                    if(food2 <= sampleFood2*1.1 && food2 >= sampleFood2*.9){
                        solution = true;
                    } 
                } else if (food1 < 0.9*sampleFood1) {
                    sampleFood1=sampleFood1/servings*(servings+1);
                    sampleFood2=sampleFood2/servings*(servings+1);
                }
            }
            if(solution == true){
                Console.WriteLine("Case #" + j + ": " + servings);
            } else {
                Console.WriteLine("Case #" + j + ": 0");
            }
            solution = true;
        }
    }
}
}
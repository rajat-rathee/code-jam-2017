using System;
using System.Collections.Generic;
using System.IO;
class bathroomstalls{
    static void Main(string[] args){
        int rownum = 1;
        List<string> norm = new List<string>();
        List<string> changed = new List<string>();

        List<int> stalls = new List<int>();
        List<int> people = new List<int>();
        using (StreamReader reader = new StreamReader("inputC.txt")) {
            string line;
            while((line = reader.ReadLine()) != null){
                norm.Add(line);
            }
            
        }
       // norm.ForEach(Console.WriteLine);

        for (int k=0; k<norm.Count; k++){
           string l = norm[k];
           norm[k] =  l.Replace(' ', '\n');
        }
       // norm.ForEach(Console.WriteLine);
        string[] fix = norm.ToArray();
        System.IO.File.WriteAllLines("input.txt", fix);
        
        using (StreamReader reader2 = new StreamReader("input.txt")) {
            string line2;
            while((line2 = reader2.ReadLine()) != null){
                changed.Add(line2);
            }
           // changed.ForEach(Console.WriteLine);
           // Console.WriteLine(changed.Count);
      
    }
     int t = (int.Parse(changed[0]));
        while(rownum < changed.Count){
            if(rownum % 2 == 1){
                stalls.Add(int.Parse(changed[rownum]));
            } else {
                people.Add(int.Parse(changed[rownum]));
            }
            rownum++;
        }
        
       //people.ForEach(Console.WriteLine);
       //stalls.ForEach(Console.WriteLine);

        
        int currindex = 1;
         int peopleleft;
        bool done = false;
        int indexwin = 1;
        int leftsum = 0;
        int rightsum = 0;
        int largesum = 0;
        int smallsum = 0;
        int stallsnumber;
        int smallsumtobeat = 0;
        int currleftsum =0;
        int currrightsum=0;
        int currentleftsumfinal=0;
        int currentrightsumfinal=0;
        int maxsumtobeat = 0;
        for(int i=1;i<=t;i++){
            peopleleft = people[i-1];
            stallsnumber = stalls[i-1];
            List<string> stallls = new List<string>(stallsnumber + 1);
            stallls.Add("X");
            for(int o=0; o < stallsnumber;o++){
                stallls.Add("O");
            }
            stallls.Add("X");
            //stallls.ForEach(Console.WriteLine);
            while(peopleleft>0){
                smallsumtobeat = 0;
                maxsumtobeat = 0;
                smallsum = 0;
                largesum = 0;
                for(int j = 1; j <= stallsnumber;j++){
                    if(stallls[j] != "X"){
                        int l = j-1;
                        done = false;
                            while(done == false){
                                if(stallls[l] == "X"){
                                currentleftsumfinal = currleftsum;
                                done = true;
                                }
                                currleftsum++;
                                l--;
                            }
                        done = false;
                        l = j+1;
                            while(done == false){
                                if(stallls[l] == "X"){
                                currentrightsumfinal = currrightsum;
                                done = true;
                                }
                                currrightsum++;
                                l++;
                            }
                        if(currentleftsumfinal >= currentrightsumfinal){
                            if(currentrightsumfinal > smallsumtobeat){
                                //Console.WriteLine(currentrightsumfinal);
                                smallsumtobeat=currentrightsumfinal;
                                smallsum=smallsumtobeat;
                                largesum=currentleftsumfinal;
                                indexwin=j;
                                maxsumtobeat=currentleftsumfinal;
                            }else if((currentrightsumfinal >= smallsumtobeat) && (currentleftsumfinal > maxsumtobeat)){
                                smallsumtobeat=currentrightsumfinal;
                                smallsum=smallsumtobeat;
                                largesum=currentleftsumfinal;
                                indexwin=j;
                                maxsumtobeat=currentleftsumfinal;
                            }
                        } else {
                            if(currentleftsumfinal > smallsumtobeat){
                                //Console.WriteLine(currentrightsumfinal);
                                smallsumtobeat=currentleftsumfinal;
                                smallsum=smallsumtobeat;
                                largesum=currentrightsumfinal;
                                indexwin=j;
                                maxsumtobeat=currentrightsumfinal;
                            }else if((currentleftsumfinal >= smallsumtobeat) && (currentrightsumfinal > maxsumtobeat)){
                                smallsumtobeat=currentleftsumfinal;
                                smallsum=smallsumtobeat;
                                largesum=currentrightsumfinal;
                                indexwin=j;
                                maxsumtobeat=currentrightsumfinal;
                            }
                        }
                        //Console.WriteLine(currentleftsumfinal);
                        //Console.WriteLine(currentrightsumfinal);
                        //stallls.ForEach(Console.WriteLine);
                        currentrightsumfinal=0;
                        currentleftsumfinal=0;
                        currleftsum=0;
                        currrightsum=0;
                    }
                    
                    
                }
                //stallls.ForEach(Console.WriteLine);
                stallls[indexwin] = "X";
                indexwin=0;
                currentrightsumfinal=0;
                currentleftsumfinal=0;
                currleftsum=0;
                currrightsum=0;
                peopleleft = peopleleft -1;
               // Console.WriteLine(peopleleft);
               //Console.WriteLine(largesum + " " + smallsum);
            }
            Console.WriteLine("Case #" + i + ": " + largesum + " " + smallsum);
        }
    }
    
}
        
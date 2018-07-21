using System;
using System.Collections.Generic;
using System.IO;
class tidynumbers{
    static void Main(string[] args){
        bool found= false;
        bool failed = true;
        List<int> list = new List<int>();
        using (StreamReader reader = new StreamReader("inputB.txt"))
        {
            string line;
            while((line = reader.ReadLine()) != null){
                list.Add(int.Parse(line));
                
            }
        }
        int temp;
        int t = list[0];
        int n;
        for(int i=1;i<=t ;i++){
            n=list[i];
            temp = n;
            while(found == false){
                temp = n;
                if(n<10){
                    found = true;
                    
                }
                
                    failed = false;
                    while(temp >= 10) {
                        if(temp % 10 < ((temp/10)%10)) {
                            failed = true;
                            
                        }
                        temp = temp/10;
                    }
                        
                
                     if(failed == false){
                        found = true;
                    }else {
                    failed = false;
                    n=n-1;
                    }
                }
                Console.WriteLine("Case #" + i + ": " + n);
                
                found = false;
                
            }
    //print "Case #"+ i + ":" + n;
}

}
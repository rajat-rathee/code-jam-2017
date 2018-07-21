using System;
using System.Collections.Generic;
using System.IO;
class countingsheep {
	static void Main(string[] args){
		List<int> list = new List<int>();
		using (StreamReader reader = new StreamReader("input.txt")){
			string line;
			while((line = reader.ReadLine()) != null){
				list.Add(int.Parse(line));
			}
		}
		int t = list[0];
		int count =2;
		bool solved = false;
		bool minisolve =false;
		for(int i=1; i<=t;i++){
			solved = false;
			List<int> seen = new List<int>();

			while (solved == false){
				if (list[i] == 0){
			Console.WriteLine("Case #" +i+ ": INSOMNIA");
			solved = true;
		}
		else{
			while(minisolve ==false){
		     int num = list[i];

				while(num>0) {
					seen.Add(num%10);
					num /= 10;
			}
			seen.ForEach(Console.WriteLine);
			if(seen.Contains(1) && seen.Contains(2)&& seen.Contains(3)&& seen.Contains(4)&& seen.Contains(5)&& seen.Contains(6)&& seen.Contains(7)&& seen.Contains(8)&& seen.Contains(9)&& seen.Contains(0)){
				Console.WriteLine("Case #" +i+ ": " + num);
				minisolve = true;
				solved = true;
			}
			else{
				num = num*count;
				count++;
			}
			}
			minisolve=false;
			

		}


		}
		}
	}
}

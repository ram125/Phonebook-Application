using System;
using System.Collections;
using System.Collections.Generic;
public class Project {
  public static void Main(String[] args){
  	List<string> names = new List<string>();
  	Dictionary<string, int> numbers = new Dictionary<string, int>();
  	string command = "";
  	string currentname = "";
  	int currentnum;
  	bool found;
  	bool stop = true;
  	while(stop){
	  	Console.WriteLine("enter your command: add, search, delete, print or exit");
	  	command = Console.ReadLine();
	  	if(command == "add"){
	  		Console.WriteLine("Please enter the name:");
	  		names.Add(Console.ReadLine());
	  		Console.WriteLine("Please enter the number:");
	  		numbers.Add(names[names.Count-1], Convert.ToInt32(Console.ReadLine()));
	  	}else if(command == "delete"){
	  		Console.WriteLine("enter value: ");
	  		currentname = Console.ReadLine();
	  		found = false;
	  		try{
	  		    currentnum = Convert.ToInt32(currentname);
	  		    for(int j=0; j<names.Count; j++){
	  		    	if(currentnum == numbers[names[j]]){
	  		    		found = true;
	  		    		numbers.Remove(names[j]);
	  		    		names.Remove(names[j]);
	  		    	}
	  		    }
	  		    if(!found){
	  		    	Console.WriteLine("doesn't exist");
	  		    }
	  		}
	  		catch (FormatException){
	  			if(names.Contains(currentname)){
			  		numbers.Remove(currentname);
			  		names.Remove(currentname);
	  			}else{

	  				Console.WriteLine("doesn't exist");
	  			}
	  		}
	  	}else if(command == "search"){
	  		Console.WriteLine("enter value: ");
	  		currentname = Console.ReadLine();
	  		found = false;
	  		try{
	  		    currentnum = Convert.ToInt32(currentname);
	  		    for(int j=0; j<names.Count; j++){
	  		    	if(currentnum == numbers[names[j]]){
	  		    		Console.WriteLine($"name: {names[j]};");
	  		    		found = true;
	  		    	}
	  		    }
	  		    if(!found){
	  		    	Console.WriteLine("doesn't exist");
	  		    }
	  		}

	  		catch (FormatException)
	  		{
	  		    Console.WriteLine(names.Contains(currentname)?$"number: {numbers[currentname]};":"doesn't exist");
	  		}
	  	}else if(command == "print"){
	  		for(int i=0; i<names.Count; i++){
	  			Console.WriteLine($"name: {names[i]}; number: {numbers[names[i]]};");
	  		}
	  	}else if(command == "exit"){
	  		stop = false;
	  	}else{
	  		Console.WriteLine("unrecognized command");
	  	}
  	}
  }
}

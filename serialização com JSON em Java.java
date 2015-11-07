package org.kodejava.example.google.gson;
 
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
 
import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;
 
public class CollectionToJson {
    public static void main(String[] args) {
        //
        // Converts a collection of string object into JSON string.
        //
        List<String> names = new ArrayList<>();
        names.add("Alice");
        names.add("Bob");
        names.add("Carol");
        names.add("Mallory");
 
        Gson gson = new Gson();
        String jsonNames = gson.toJson(names);
        System.out.println("jsonNames = " + jsonNames);
 
        //
        // Converts a collection Student object into JSON string
        //
        Student a = new Student("Alice", "Apple St",
                CollectionToJson.getDOB(2000, 10, 1));
        Student b = new Student("Bob", "Banana St", null);
        Student c = new Student("Carol", "Grape St",
                CollectionToJson.getDOB(2000, 5, 21));
        Student d = new Student("Mallory", "Mango St", null);
 
        List<Student> students = new ArrayList<>();
        students.add(a);
        students.add(b);
        students.add(c);
        students.add(d);
 
        gson = new Gson();
        String jsonStudents = gson.toJson(students);
        System.out.println("jsonStudents = " + jsonStudents);
 
        //
        // Converts JSON string into a collection of Student object.
        //
        Type type = new TypeToken<List<Student>>() {
        }.getType();
        List<Student> studentList = gson.fromJson(jsonStudents, type);
 
        for (Student student : studentList) {
            System.out.println("student.getName() = " + student.getName());
        }
    }
 
    private static Date getDOB(int year, int month, int date) {
        Calendar calendar = Calendar.getInstance();
        calendar.set(Calendar.YEAR, year);
        calendar.set(Calendar.MONTH, month - 1);
        calendar.set(Calendar.DATE, date);
        calendar.set(Calendar.HOUR, 0);
        calendar.set(Calendar.MINUTE, 0);
        calendar.set(Calendar.SECOND, 0);
        return calendar.getTime();
    }
}

================================================

package exercícios_1_10;
import java.util.Scanner;

import com.google.gson.Gson;

public class Teste {
	public static void main(String[] args) {
		
		String j = new Gson().toJson(car);
		System.out.println(j);
	}
}

class Itens
{
	string categoria = "Sem categoria";
	string servico;
	string email;
	string senha;

	public string Categoria
	{
		get { return categoria; }
		set { categoria = value; }
	}

	public string Servico
	{
		get { return servico; }
		set { servico = value; }
	}

	public string Email
	{
		get { return email; }
		set { email = value; }
	}

	public string Senha
	{
		get { return senha; }
		set { senha = value; }
	}

	public Itens(string _servico, string _email, string _senha)
	{
		servico = _servico;
		email = _email;
		senha = _senha;
	}

	public Itens(string _categoria, string _servico, string _email,
		string _senha)
	{
		categoria = _categoria;
		servico = _servico;
		email = _email;
		senha = _senha;
	}
}
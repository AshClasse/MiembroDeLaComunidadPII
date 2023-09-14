public class MiembroDeLaComunidad
{
    string Nombre {  get; set; }
    int Edad {  get; set; }

    public MiembroDeLaComunidad(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

public class Estudiante : MiembroDeLaComunidad
{
    string Matricula { get; set; }
    string Carrera { get; set; }

    public Estudiante(string nombre, int edad, string matricula, string carrera): base(nombre, edad)
    {
        Matricula = matricula;
        Carrera = carrera;
    }
}

public class ExAlumno : MiembroDeLaComunidad
{

    int Generación { get; set; }

    public ExAlumno(string nombre, int edad, int generacion) : base(nombre, edad)
    {
        Generación = generacion;
    }
}

public class Empleado : MiembroDeLaComunidad
{
    int Salario { get; set; }
    int ID { get; set; }

    public Empleado(string nombre, int edad, int salario, int id) : base(nombre, edad)
    {
        Salario = salario;
        ID = id;
    }
}

public class Administrativo : Empleado
{
    public Administrativo(string nombre, int edad, int salario, int id) : base(nombre, edad, salario, id)
    {}
}

public class Docente : Empleado
{
    string Materia { get; set; }
    public Docente(string nombre, int edad, int salario, int id, string materia) : base(nombre, edad, salario, id)
    {
        Materia = materia;
    }
}

public class Administrador : Docente
{
    public Administrador(string nombre, int edad, int salario, int id, string materia) : base(nombre, edad, salario, id, materia)
    {}
}

public class Maestro : Docente
{
    public Maestro(string nombre, int edad, int salario, int id, string materia) : base(nombre, edad, salario, id, materia)
    { }
}






public class Cliente: Persona
{
    public double Saldo { get; set; }
    public Cliente(int codigo, string nombre)
    {
        Codigo = codigo;
        Nombre = nombre;
    }
}
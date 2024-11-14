//try
//{
//    Veiculo v1 = new Veiculo();

//    v1.SetNiv("0561561");
//    v1.modelo = "Saveiro G6";
//    v1.placa = "QBE-8324";

//    Console.WriteLine(v1.getNiv());

//} catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    Cliente c1 = new Cliente();

    c1.setCpf("123.459.789-10");

    Console.WriteLine(c1.getCpf());

}catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


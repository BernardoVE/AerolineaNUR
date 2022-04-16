// See https://aka.ms/new-console-template for more information
using Aerolinea.aREGISTRO_TRIPULACION.Model.CONTROL_PERSONAL;
using Aerolinea.aREGISTRO_TRIPULACION.Model.PLANILLA_SUELDOS;
//IdFuncionario Paterno	Materno	Nombre	Direccion	Telefono	CtaBanco
//1116790	ZEBALLOS	ADAD	ADELA	DIRECCION  1908	94154433	123005917
//1128374	ZURITA	 	ABEL	DIRECCION  3541	79394649	123003767
//1133081	ROCHA	CUELLAR	FELIX EDGAR	DIRECCION  2759	88840808	123003083
//1135335	CUELLAR	ROCHA	NELLY MARIEL	DIRECCION  110	93085573	123003661
//1139320	VALVERDE	ARTEAGA	AURORA	DIRECCION  2353	91020346	123003904

//IdFuncionario IdSitio	IdCargo	IdNivel	FechaIngreso	Estado
//1116790	10107	V20101	N10102	02/11/2010	Falso
//IdSitio PAIS	DEPARTAMENTO	MUNICIPIO	DIRECCION	TELEFONO	CONTINENTE
//10101	BOLIVIA	LA PAZ	NUESTRA SEÑORA DE LA PAZ	HEROES DEL CHACO	31321210	NACIONAL
//IdCargo TipoCargo	DescripcionCargo
//C10101	ADMINISTRATIVO	ABOGADO
//IdNivel Nivel	Basico
//N10102	NIVEL 2	7819

Funcionarios FFuncionarios = new Funcionarios("1116790","ZEBALLOS","ADAD","ADELA","DIRECCION  1908","94154433","123005917");
DateTime thisDate1 = new DateTime(2011, 6, 10);
KardexFuncionario KFuncionario = new KardexFuncionario("1116790", "10107", "V20101", "N10102", new DateTime(2010, 11, 02), false);
Oficinas Oficina= new Oficinas("10101", "BOLIVIA", "LA PAZ", "NUESTRA SEÑORA DE LA PAZ", "HEROES DEL CHACO","31321210","NACIONAL");
CargoFuncionario Cargo = new CargoFuncionario("C10101", "ADMINISTRATIVO", "ABOGADO");
NivelFuncionario Nivel = new NivelFuncionario("N10102", "NIVEL 2", 7819);
PlanillaFuncionario Planilla = new PlanillaFuncionario(5, 2022, "1116790", 7819, 30, 500, 400, (decimal)100.50, (decimal) 8819.5, 100, 0, 0, 0, 0, 100, (decimal)8719.5, new DateTime(2022, 05, 30));

Console.WriteLine(FFuncionarios.IdFuncionario);
Console.WriteLine(KFuncionario.FechaIngreso);
Console.WriteLine(KFuncionario.Estado);
Console.WriteLine(Oficina.Municipio);
Console.WriteLine(Cargo.TipoCargo);
Console.WriteLine(Nivel.Basico);
Console.WriteLine(Planilla.TotalGanado);


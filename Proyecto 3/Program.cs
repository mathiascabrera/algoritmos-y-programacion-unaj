using System;

namespace Proyecto_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			//PROYECTO 3
			
			Console.WriteLine("¡Bienvenido a VisionPower!");
			
			Empresa vision = new Empresa();
			
			//Creamos tecnicos y agregamos a Empresa
			
			//Atributos Tecnico = string nombre, string apellido, int documento, int area, int legajo
			
			Tecnico tec_uno = new Tecnico("Robert", "Gonzalez", 45255898,1,1234);
			vision.AgregarTecnico(tec_uno);
			
			Tecnico tec_dos = new Tecnico("Nicolas", "Hernandez",47858969,2,4321);
			vision.AgregarTecnico(tec_dos);
			
			Tecnico tec_tres = new Tecnico("Marcos", "Perez",47558961,3,2341);
			vision.AgregarTecnico(tec_tres);
			
			Tecnico tec_cuatro = new Tecnico("Franco", "Morales",45578963,4,3124);
			vision.AgregarTecnico(tec_cuatro);
			
			
			//Creo dos DateTime. La primera para que no acceda a la promocion, y la segunda para que sí cuente con la oferta.
			//Esta fecha corresponde a la fecha de alta.
			//La fecha de promocion es durante todo el mes de noviembre del 2022.
			
			DateTime fecha1 = new DateTime(2022,10,19);
			DateTime fecha2 = new DateTime(2022,11,19);
			
			//Creamos Clientes y agregamos a Empresa
			//Atributos Cliente = string Nombre, string Apellido, int Documento, int NumCliente,int PlanVigente, int Costo, int Area,
								//string NombreTecnico, DateTime Fecha, bool ComboExtra
			Cliente cliente1 = new Cliente("Rodrigo","Sanchez",54897123,1,1,80,1,tec_uno.NombreSetGet,fecha1,false);
			vision.AgregarCliente(cliente1);
			
			Cliente cliente2 = new Cliente("Susana","Manchado",45632236,2,2,120,2,tec_dos.NombreSetGet,fecha2,true);
			vision.AgregarCliente(cliente2);
			
			Cliente cliente3 = new Cliente("Rodolfo","Jimenez",43521365,3,3,180,3,tec_tres.NombreSetGet,fecha2,true);
			vision.AgregarCliente(cliente3);
			
			Cliente cliente4 = new Cliente("Cristina","Bustamante",44789521,4,220,220,4,tec_cuatro.NombreSetGet,fecha1,false);
			vision.AgregarCliente(cliente4);
			
			
			//La variable menu posee todas las opciones que el usuario puede utlizar para satisfacer sus necesidades.
			const string menu="\nPresione 1 para registrar a un nuevo cliente.\n" +
				"\n"+
				"Presione 2 para modificar la cantidad de minutos consumidos por un cliente dado.\n" +
				"\n"+
				"Presione 3 para eliminar un cliente\n" +
				"\n"+
				"Presione 4 para imprimir los nombre de los tecnicos a paritr de un area determinda\n" +
				"\n"+
				"Presione 5 para ver el listado de cliente\n" +
				"\n" +
				"Presione 6 para agregar un nuevo tecnico\n" +
				"\n"+
				" Presione 7 para imprimir la facturacion de un cliente.\n" +
				"\n"+
				"Presione 8 para ver el listado de tecnicos.\n" +
				"\n"+
				"Presione 0 para finalizar.";
			
			int opcion = 9;
			
			try {
				Console.WriteLine(menu);
				Console.WriteLine("\nIngrese una opcion: ");
				opcion=Convert.ToInt32(Console.ReadLine());				
				
				while (opcion !=0 && opcion !=1 && opcion !=2 && opcion !=3 && opcion !=4 && opcion !=5 && opcion !=6 && opcion !=7 && opcion !=8) {
					
					Console.WriteLine("\nValor ingresado no valido. Por favor, vuelva a intentarlo.");
					Console.WriteLine(menu);
					Console.WriteLine("\nIngrese una opcion: ");
					opcion=Convert.ToInt32(Console.ReadLine());
				}
				
			} catch (Exception error) {
				
				Console.WriteLine("\nLo sentimos, ocurrio el siguiente error: "+error.Message);
			}
			
			while (opcion != 0) {
				
				switch (opcion) {
					case 1 :
						RegistrarCliente(vision);
						break;
						
					case 2 :
						MinutosConsumidos(vision);
						break;
						
					case 3 :
						EliminarCliente(vision);
						break;
						
					case 4 :
						ImprimirTecnico(vision);
						break;
						
					case 5 :
						ListadoClientes(vision);
						break;
						
					case 6 :
						RegistrarTecnico(vision);
						break;
						
					case 7 :
						Facturar(vision);
						break;
						
					case 8 :
						ListadoTecnicos(vision);
						break;
						
					default:
						Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
						break;
				}
				
				try {
				Console.WriteLine(menu);
				Console.WriteLine("\nIngrese una opcion: ");
				opcion=Convert.ToInt32(Console.ReadLine());
				
				while (opcion !=0 && opcion !=1 && opcion !=2 && opcion !=3 && opcion !=4 && opcion !=5 && opcion !=6 && opcion !=7 && opcion !=8) {
					Console.WriteLine("\nValor ingresado no valido. Por favor, vuelva a intentarlo.");
					Console.WriteLine(menu);
					Console.WriteLine("\nIngrese una opcion: ");
					opcion=Convert.ToInt32(Console.ReadLine());
				}
				
			} catch (Exception error) {
				Console.WriteLine("\nLo sentimos, ocurrio el siguiente error: "+error.Message);
				
				opcion = 9;
				}
			}
			
			Console.WriteLine("\n¡Muchas gracias por utilizar nuestro programa!");
		
			Console.WriteLine("\nPresione cualquier tecla para cerrar.");
			
			Console.ReadKey(true);
		}
		
		public static void RegistrarCliente(Empresa vision){
			
			//Atributos de la clase Cliente
			//string Nombre, string Apellido, int Documento,int PlanVigente, int Costo, int Area, string NombreTecnico, DateTime Fecha, bool ComboExtra
			
			string nombre, apellido, nom_tecnico="vacio";
			int documento, plan, costo = 0, area, dia, mes, anio, numcliente;
			bool comboextra = false;//esta variable hace referencia a la oferta, mas adelante se trabajará con ella, pero de momento
			//queda en false, significando que no cuenta con la oferta. Luego con algunas estructuras condicionales se calculará
			//si al cliente le corresponde la oferta.
			
			Cliente nuevoCliente;
			
			try {
				Console.WriteLine("\nPor favor ingrese su nombre: ");
				nombre=Console.ReadLine();				
				Console.WriteLine("\nPor favor ingrese su apellido: ");
				apellido=Console.ReadLine();
				
				Console.WriteLine("\nPor favor ingrese su documento sin puntos: ");
				documento=int.Parse(Console.ReadLine());
				
				int intentos = 0;
				
				while (documento <= 20000000 || documento >= 100000000) {//Damos un rango de valores que seria aceptable para el número de documentos
					
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor ingrese su documento sin puntos: ");
					documento=int.Parse(Console.ReadLine());
					
					if (documento <= 20000000 || documento >= 100000000) {
						intentos = intentos + 1;//Si el usuario nuevamente ingresó mal el dni incrementamos el valor de intento
					}
					if (intentos == 2) {
						throw new ExcepcionDocumento(documento);//Si se ha realizado 2 intentos seguidos lanzamos la Excepcion
					}
				}
				
				//Si todo sale bien, es decir, si no se superan los dos intentos dentro del while, intentos es igual a cero.
				//Lo igualamos a cero ya que luego volveremos a utilizarla con el mismo propósito.
				
				intentos = 0;
				
				
				//INICIAMOS A TRABAJAR CON LA VARIABLE PLAN
				
				//Existen 4 combos.
				//Cada uno incluye cable HD básica de 121 canales y telefonía.
				//Los combos varían en los minutos libres y el costo por minuto de comunicación.
				//Existe una promoción que consta de un 15% de descuento del costo mensual del combo
				//para los clientes que hayan consumido menos del 85% de los minutos libres de su plan.
				
				//Informamos al usuario qué incluye cada combo y su precio respectivamente.
				
				Console.WriteLine("\nTe ofrecemos 4 combos, cada uno con cable HD básica de 121 canales y telefonía, varían en los minutos libres y el costo por minuto de comunicación.\n" +
				                  "Combo 1 = 90 minutos libres y un costo de $80 por minuto de comunicación.\n" +
				                  "Combo 2 = 120 minutos libres y un costo de $120 por minuto de comunicación.\n" +
				                  "Combo 3 = 150 minutos libres y un costo de $180 por minuto de comunicación.\n" +
				                  "Combo 4 = 180 minutos libres y un costo de $220 por minuto de comunicación.");
				
				Console.WriteLine("\nPor favor ingrese 1 para obtener el combo 1,\n" +
				                  "2 para el combo 2,\n" +
				                  "3 para el combo 3," +
				                  "o 4 para obtener el combo 4: ");
				
				plan=int.Parse(Console.ReadLine());
				
				while (plan != 1 && plan != 2 && plan != 3 && plan != 4) {
					
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					
					Console.WriteLine("\nTe ofrecemos 4 combos, cada uno con cable HD básica de 121 canales y telefonía, varían en los minutos libres y el costo por minuto de comunicación.\n" +
					                  "Combo 1 = 90 minutos libres y un costo de $80 por minuto de comunicación.\n" +
					                  "Combo 2 = 120 minutos libres y un costo de $120 por minuto de comunicación.\n" +
					                  "Combo 3 = 150 minutos libres y un costo de $180 por minuto de comunicación.\n" +
					                  "Combo 4 = 180 minutos libres y un costo de $220 por minuto de comunicación.");
					
					Console.WriteLine("\nPor favor ingrese 1 para obtener el combo 1,\n" +
					                  "2 para el combo 2,\n" +
					                  "3 para el combo 3," +
					                  "o 4 para obtener el combo 4: ");
					
					plan=int.Parse(Console.ReadLine());
					
					if (plan != 1 && plan != 2 && plan != 3 && plan != 4) {
						//Si el usuario nuevamente ingresó mal el plan incrementamos el valor de intento
						intentos = intentos + 1;
					}
					if (intentos == 2) {
						//Si se ha realizado 2 intentos seguidos lanzamos la Excepcion
						throw new ExcepcionPlan(plan);
					}
				}
				//Si todo sale bien, es decir, si no se superan los dos intentos dentro del while, intentos es igual a cero.
				//Lo igualamos a cero ya que luego volveremos a utilizarla con el mismo propósito.
				intentos = 0;
				
				//Suponiendo que se ingresó correctamente el valor numérico para plan creamos un Switch.
				//Este switch, dependiendo del valor de plan, asignará un valor a la variable costo, que es el costo por minuto de comunicación.
				switch (plan) {
					
					case 1:
						//Si el plan es el 1 (Combo 1), entonces el costo será de $80 por minuto de comunicación.
						costo=80;
						break;
					
					case 2:
						//Si el plan es el 2 (Combo 2), entonces el costo será de $120 por minuto de comunicación.
						costo=120;
						break;
						
					case 3:
						//Si el plan es el 3 (Combo 3), entonces el costo será de $180 por minuto de comunicación.
						costo=180;
						break;
						
					case 4:
						//Si el plan es el 4 (Combo 4), entonces el costo será de $220 por minuto de comunicación.
						costo=220;
						break;
				}
				
				//Area :
				Console.WriteLine("\nIngrese 1 si vive en Berazategui,\n" +
				                  "2 si vive en F.cio Varela,\n" +
				                  "3 si vive en Quilmes." +
				                  "4 si vive en La Plata.");
				
				Console.WriteLine("\nPor favor ingrese su area: ");
				area =int.Parse(Console.ReadLine());
				
				while (area !=1 & area !=2 & area !=3 & area !=4) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor ingrese su area: ");
					area =int.Parse(Console.ReadLine());
					
					
					if (area !=1 & area !=2 & area !=3 & area !=4) {
						intentos = intentos + 1;
					}
					if (intentos == 2) {
						throw new ExcepcionArea(area);
					}
				}
				intentos = 0;

				//ARRANCAMOS A TRABAJAR CON LAS VARIABLES REFERENTES AL TECNICO
				
				
				//La finalidad de este segmento es hallar el nombre del tecnico asignado al área donde reside el cliente.
				//Para ello necesitamos la cantidad de tecnicos (Para luego probar con cada tecnico - esto se puede apreciar en el cuerpo del for).

				int cantidadtecnicos = vision.CantidadTecnicos();
				int areatecnico;
				Tecnico tecnico_a_evaluar = new Tecnico();
				
				for (int r = 0; r < cantidadtecnicos; r++) {
					
					//Al tecnico que habiamos creado le cargamos el tecnico de la posicion r del listado de tecnicos.
					tecnico_a_evaluar=vision.RecuperarTecnico(r);
					
					//A la variable areatecnico le agregamos el area asignado al tecnico de la posicion r del listado de tecnicos.
					areatecnico = tecnico_a_evaluar.AreaSetGet;
					
					//Ahora comparamos si el area del tecnico de la posicion r del listado es igual al area introducido por el usuario.
					if (areatecnico == area) {
						nom_tecnico=tecnico_a_evaluar.NombreSetGet;
					}
				}
				if (nom_tecnico == "vacio") {
					
					string localidad="";
					
					switch (area) {
							
						case 1:
							//Si area es 1, localidad será Berazategui.
							localidad = "Berazategui";
							break;
							
						case 2:
							//Si area es 2, localidad será Florencio Varela.
							localidad = "Florencio Varela";
							break;
							
						case 3:
							//Si area es 3, localidad será Quilmes.
							localidad = "Quilmes";
							break;
							
						case 4:
							//Si area es 4, localidad será La Plata.
							localidad = "La Plata";
							break;
					}
					
					throw new ExcepcionAreaTecnico(localidad);
					
				}
				
				//EMPEZAMOS A TRABAJAR CON LAS VARIABLES DE LA FECHA Y LAS REFERENTES A LA OFERTA
				
				Console.WriteLine("\nPor favor ingrese el dia en numero (valor permitido 1 al 31): ");
				dia=int.Parse(Console.ReadLine());
				
				while (dia <=0 || dia > 31) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor ingrese el dia en numero (valor permitido 1 al 31): ");
					dia=int.Parse(Console.ReadLine());
					
					if (dia <=0 || dia > 31) {
						intentos = intentos +1;
					}
					
					if (intentos == 2) {
						throw new ExcepcionDia(dia);
					}
				}
				intentos = 0;
				
				Console.WriteLine("\nPor favor ingrese el mes en numero (valor permitido 1 al 12): ");
				mes=int.Parse(Console.ReadLine());
				
				while (mes <=0 || mes > 12) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor ingrese el mes en numero (valor permitido 1 al 12): ");
					mes=int.Parse(Console.ReadLine());
					
					if (mes <=0 || mes > 12) {
						intentos = intentos +1;
					}
					if (intentos == 2) {
						throw new ExcepcionMes(mes);
					}
				}
				intentos = 0;
				
				//Solicitamos al usuario que ingrese el numero del año (debe ser 2022).
				Console.WriteLine("\nPor favor ingrese el año en numero : ");
				anio=int.Parse(Console.ReadLine());
				
				while (anio <=2021 || anio > 2022) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor ingrese el año en numero : ");
					anio=int.Parse(Console.ReadLine());
					
					if (anio <=2021 || anio > 2022) {
						intentos = intentos +1;
					}
					if (intentos == 2) {
						throw new ExcepcionAño(anio);
					}
				}				
				intentos = 0;
						
				//Se lanza una oferta por tiempo limitado y cupo restringido.
				//La oferta consta de agregar el pack de fútbol y Disney Channel a cada uno de los 4 combos, al mismo precio del combo original
				//Osea que al facturarlo hay que multiplicarlo por dos. Combo elegido + Combo Plus
				 
				//A partir de acá empezamos a trabajar con los datos brindados por el usuario, veremos si le corresponde la oferta.
				
				//Una vez que se hayan cargado correctamente el dia, el mes y el año
				//cargamos los datos en una variable del tipo DateTime llamada fecha:
				DateTime fecha = new DateTime(anio,mes,dia);
				
				
				//La oferta inicia el 1 de noviembre del 2022
				//Para almacenar esta informacion, creamos una variable del tipo DateTime:
				DateTime inicio_oferta = new DateTime(2022,11,1);
				
				
				//La oferta finaliza el 30 de noviembre del 2022
				//Para almacenar esta informacion, creamos una variable del tipo DateTime:
				DateTime fin_oferta = new DateTime(2022,11,30);
				

				
				//Creamos una varaible, de numeros enteros, llamada cupo.
				//La cual va a tener la cantidad de cupos para la oferta
				//Elegimos el 6 para que no sea muy larga la carga de datos, y así poder comprobar el funcionamiento del programa.
				
				const int cupo = 6;//Ya tenemos 4 clientes que cuentan con la oferta en el main 
				
				Console.WriteLine("\nTe informamos que tenemos una oferta por tiempo limitado y cupo restringido.\n" +
				                  "Consiste en agregar el combo Plus a tu plan.\n" +
				                  "¡Incluye el pack de fútbol y Disney Channel!.\n" +
				                  "La oferta es desde el 01/11/2022 hasta el 30/11/2022.");
				
				int cantidadclientes = vision.CantidadClientes();
				
				//Esta variable va a tener el numero del mes en el que inicia la oferta.
				int mesoferta = inicio_oferta.Month;
				
				//Esta variable va a tener el numero del dia en el que inicia la oferta.
				int dia_inicio_oferta = inicio_oferta.Day;
				
				//Esta variable va a tener el numero del dia en el que finaliza la oferta.
				int dia_fin_oferta = fin_oferta.Day;
				
				//La primera condición que establecemos es si el mes, ingresado por el usuaruio, es igual al mes de la oferta.
				//Si no se cumple la condicion, se lanza la excepcion ExcepcionFueraDeTiempo
				if (mes == mesoferta) {
					
					if (dia >= dia_inicio_oferta  &  dia <= dia_fin_oferta) {
						
						if (cupo > cantidadclientes) {
							Console.WriteLine("\n¡Felicitaciones! Contas con el combo Plus.");
							comboextra = true;
						}else{
							throw new ExcepcionCupoInsuficiente();
						}
					}else{
						throw new ExcepcionFueraDeTiempo();
					}
				}else{
					throw new ExcepcionFueraDeTiempo();
				}
				
				
				//Atributos de Cliente
				//string Nombre, string Apellido, int Documento, int NumCliente,int Plan_Vigente, int Costo, int Area, string Nom_Tec, DateTime Fecha, bool ComboExtra
				
				numcliente = cantidadclientes + 1;
				
				nuevoCliente = new Cliente (nombre,apellido,documento,numcliente,plan,costo,area,nom_tecnico,fecha,comboextra);
				
				if (!vision.ExisteCliente(nuevoCliente)) {
					vision.AgregarCliente(nuevoCliente);
					Console.WriteLine("\nLa inscripcion se realizó correctamente.");
				}else{
					throw new ExcepcionClienteExistente(nombre);
				}
			}catch(ExcepcionDocumento a){
				Console.WriteLine("\nEl numero de documento "+a.documento+" no es valido.");
				
			}catch(ExcepcionPlan b){				
				Console.WriteLine("\nEl numero de plan "+b.numero+" no es valido.");
				
			}catch(ExcepcionArea c){				
				Console.WriteLine("\nEl numero de area "+c.numero+" no es valido.");
			
			}catch(ExcepcionAreaTecnico d){
				Console.WriteLine("\nEn este momento no estamos contando con ningún técnico en la zona de {0}. Por favor, vuelva a intentarlo en otro momento. Gracias.",d.area);
				
			}catch(ExcepcionDia e){
				Console.WriteLine("\nEl valor numerico "+e.numero+" no es valido para el día.");
				
			}catch( ExcepcionMes f){
				Console.WriteLine("\nEl valor numerico "+f.numero+" no es valido para el mes.");
				
			}catch(ExcepcionAño g){
				Console.WriteLine("\nEl valor numerico "+g.numero+" no es valido para el año.");
				
			}catch(ExcepcionFueraDeTiempo){
				Console.WriteLine("\nLo sentimos, la oferta ya expiró.");
				
			}catch(ExcepcionCupoInsuficiente){
				Console.WriteLine("\nLo sentimos, ya no hay cupos libres.");
				
			}catch(ExcepcionClienteExistente h){
				Console.WriteLine("\nLos datos de {0} no fueron cargados correctamente, debido a que ya se encuentra inscripto.",h.nombre);
				
			}
			catch (Exception a) {
				Console.WriteLine("\nSe ha producido el siguiente error: "+a.Message);
			}
		}
			
		
		public static void MinutosConsumidos(Empresa vision){
			
			int numcliente, totalclientes, minutosconsumidos;
			
			bool busqueda = false;//Esta variable nos va a servir para saber si se encontró al cliente deseado
			
			Cliente clienteprueba = new Cliente();
			
			try {
				//Solicitamos al usuario que ingrese el numero del cliente al que quiere modificar los minutos consumidos
				Console.WriteLine("\nPor favor introduzca el numero del cliente: ");
				numcliente = int.Parse(Console.ReadLine());
				
				int intentos = 0;
				
				while (numcliente < 0) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					
					Console.WriteLine("\nPor favor introduzca el numero del cliente: ");
					numcliente = int.Parse(Console.ReadLine());
					
					if (numcliente < 0) {
						intentos = intentos +1;
					}
					if (intentos == 2) {
						throw new ExcepcionNumCliente(numcliente);
					}
				}				
				intentos = 0;
				
				totalclientes = vision.CantidadClientes();
				
				
				
				//Creamos un for para inspeccionar y comparar los numeros de clientes con el ingresado por el usuario  
				for (int i = 0; i < totalclientes; i++) {
					
					clienteprueba = vision.RecuperarCliente(i);
					
					if (clienteprueba.NumClienteSetGet == numcliente) {
						
						Console.WriteLine("\nIntroduzca los minutos consumidos: ");
						minutosconsumidos=Convert.ToInt32(Console.ReadLine());
						
						while (minutosconsumidos <0) {
							Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
							Console.WriteLine("\nIntroduzca los minutos consumidos: ");
							minutosconsumidos=Convert.ToInt32(Console.ReadLine());
							
							if (minutosconsumidos <0) {
								intentos = intentos + 1;
							}
							if (intentos == 2) {
								throw new ExcepcionMinutos(minutosconsumidos);
							}
						}						
						clienteprueba.MinutosSetGet=minutosconsumidos;
						busqueda=true;
					}
				}				
				if (!busqueda) {
					throw new ExcepcionClienteInexistente(numcliente);
				}else{
					Console.WriteLine("\nLa operacion se ha realizado con exito.");
				}
			}catch(ExcepcionNumCliente a){
				Console.WriteLine("\nEl numero "+a.numero+" no es valido para el numero de cliente.");
				
			}catch(ExcepcionMinutos b){
				Console.WriteLine("\nEl numero {0} no es valido para los minutos consumidos.",b.numero);
				
			}catch(ExcepcionClienteInexistente c){
				Console.WriteLine("\nLo sentimos, no se encontró al cliente con el numero "+c.numero+".");
			}
			catch (Exception x) {				
				Console.WriteLine("\nSe ha producido el siguiente error: "+x.Message);
			}
		}
		
		public static void EliminarCliente(Empresa vision){
			
			//La idea es eliminar al cliente a partir de su numero de cliente.			
			int numcliente;
			Cliente clienteprueba;
			bool comprobacion = false;//Esta variable la vamos a usar para saber si se ha encontrado y eliminado correctamente al cliente deseado.
			int cant_clientes = vision.CantidadClientes();
			
			try {
				Console.WriteLine("\nPor favor introduzca el numero de cliente: ");
				numcliente=int.Parse(Console.ReadLine());
				
				int intentos = 0;
				
				while (numcliente < 0) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor introduzca el numero del cliente: ");
					numcliente = int.Parse(Console.ReadLine());
					
					if (numcliente < 0) {
						intentos = intentos +1;						
					}					
					if (intentos == 2) {						
						throw new ExcepcionNumCliente(numcliente);
					}
				}				
				intentos = 0;
				
				for (int i = 0; i < cant_clientes; i++) {
					
					clienteprueba=vision.RecuperarCliente(i);
					
					if (clienteprueba.NumClienteSetGet == numcliente) {
						
						vision.EliminarCliente(clienteprueba);
						Console.WriteLine("\nSe han eliminado correctamente los datos del cliente con numero {0}.", numcliente);
						comprobacion = true;
						break;
					}
				}
				
				if (!comprobacion) {					
					throw new ExcepcionClienteInexistente(numcliente);
				}
			}catch(ExcepcionNumCliente a){
				Console.WriteLine("\nEl numero "+a.numero+" no es valido para el numero de cliente.");
				
			}catch(ExcepcionClienteInexistente b){
				Console.WriteLine("\nLo sentimos, no se encontró al cliente con el numero "+b.numero+".");
			}
			catch (Exception c) {
				Console.WriteLine("\nSe ha producido el siguiente error: "+c.Message);
			}
		}
		
		public static void ImprimirTecnico(Empresa vision){
			
			//La idea es imprimir los datos de los tecnicos de algunas de las localidades en las que se ofrece el servicio.
			int area;
			Tecnico tecnicoprueba;
			
			try {
				Console.WriteLine("\nIngrese 1 si desea ver los datos de los tecnicos de Berazategui,\n" +
				                  "2 para los de F.cio Varela,\n" +
				                  "3 para los de Quilmes." +
				                  "4 para los de La Plata: ");
				area=int.Parse(Console.ReadLine());
				
				int intentos = 0;
				
				while (area !=1 & area !=2 & area !=3 & area !=4) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nIngrese 1 si desea ver los datos de los tecnicos de Berazategui,\n" +
					                  "2 para los de F.cio Varela,\n" +
					                  "3 para los de Quilmes." +
					                  "4 para los de La Plata: ");
					area =int.Parse(Console.ReadLine());
					
					if (area !=1 & area !=2 & area !=3 & area !=4) {
						intentos = intentos + 1;
					}
					
					if (intentos == 2) {
						throw new ExcepcionArea(area);
					}
				}
				int cantidadtecnicos = vision.CantidadTecnicos();
				
				//Esta variable comprobador nos ayudará a saber si se imprimió al menos una vez los datos de algun tecnico de la zona solicitada.
				bool comprobador = false;
				
				for (int i = 0; i < cantidadtecnicos; i++) {
					tecnicoprueba=vision.RecuperarTecnico(i);
					
					if (tecnicoprueba.AreaSetGet == area) {
						comprobador = true;
						
						Console.WriteLine("\nNombre: {0}.\n" +
						                  "Apellido: {1}.\n" +
						                  "Legajo: {2}.",tecnicoprueba.NombreSetGet, tecnicoprueba.ApellidoSetGet, tecnicoprueba.LegajoSetGet);
					}
				}
				
				if (!comprobador) {
					
					string localidad="";//Esta variable nos va a servir para lanzar la excepción
					
					switch (area) {
							
						case 1:
							localidad = "Berazategui";
							break;
							
						case 2:
							localidad = "Florencio Varela";
							break;
							
						case 3:
							localidad = "Quilmes";
							break;
							
						case 4:
							localidad = "La Plata";
							break;
					}					
					throw new ExcepcionAreaTecnico(localidad);
				}
			}catch(ExcepcionArea a){
				Console.WriteLine("\nEl numero de area "+a.numero+" no es valido.");
			
			}catch(ExcepcionAreaTecnico b){
				Console.WriteLine("\nEn este momento no estamos contando con ningún técnico en la zona de {0}. Por favor, vuelva a intentarlo en otro momento. Gracias.",b.area);
			
			}
			catch (Exception d) {
				Console.WriteLine("\nSe ha producido el siguiente error: "+d.Message);
				
			}	
		}
		
		public static void ListadoClientes(Empresa vision){
			
			Cliente clienteprueba; string comboextra;
			int cantidad_clientes = vision.CantidadClientes();
			
			for (int c = 0; c < cantidad_clientes; c++) {
				clienteprueba=vision.RecuperarCliente(c);
				
				if (!clienteprueba.ComboExtraSetGet) {					
					comboextra = "No posee";
				}else{
					comboextra = "Si posee";
				}
				
				Console.WriteLine("\nNombre y apellido : {0} {1}.\n" +
				                  "Documento : {2}.\n" +
				                  "Numero de cliente: {3}.\n" +
				                  "Plan : {4}.\n" +
				                  "Costo : {5}.\n" +
				                  "Area : {6}.\n" +
				                  "Tecnico Asignado : {7}.\n" +
				                  "Fecha de alta : {8} {9} {10}.\n" +
				                  "Combo extra : {11}.\n" +
				                  "Minutos Consumidos: {12}.", clienteprueba.NombreSetGet, clienteprueba.ApellidoSetGet,clienteprueba.DocumentoSetGet , clienteprueba.NumClienteSetGet, clienteprueba.PlanSetGet,clienteprueba.CostoSetGet, clienteprueba.AreaSetGet, clienteprueba.NomTecSetGet, clienteprueba.FechaSetGet.Day, clienteprueba.FechaSetGet.Month, clienteprueba.FechaSetGet.Year, comboextra, clienteprueba.MinutosSetGet);
			}
		}
		
		public static void RegistrarTecnico(Empresa vision){
			
			//Propiedades Clase Tecnico
			//string nom, string ape, int doc, int area, int legajo
			
			string nombre, apellido;
			int documento, area, legajo;
			
			try {
				Console.WriteLine("\nPor favor introduzca el nombre: ");
				nombre=Console.ReadLine();
				
				Console.WriteLine("\nPor favor introduzca el apellido: ");
				apellido=Console.ReadLine();
				
				Console.WriteLine("\nPor favor introduzca el documento sin puntos: ");
				documento=int.Parse(Console.ReadLine());
				
				int intentos = 0;
				
				while (documento <= 20000000 || documento >= 100000000) {//Damos un rango de valores que seria aceptable el numero de documentos
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor ingrese su documento sin puntos: ");
					documento=int.Parse(Console.ReadLine());
					
					if (documento <= 20000000 || documento >= 100000000) {
						intentos = intentos + 1;
					}
					if (intentos == 2) {						
						throw new ExcepcionDocumento(documento);
					}
					
				}
				intentos = 0;	
				Console.WriteLine("\nIngrese 1 si vive en Berazategui,\n" +
				                  "2 si vive en F.cio Varela,\n" +
				                  "3 si vive en Quilmes." +
				                  "4 si vive en La Plata.");
				Console.WriteLine("\nPor favor introduzca el area: ");
				area=int.Parse(Console.ReadLine());
				
				while (area !=1 & area !=2 & area !=3 & area !=4) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					Console.WriteLine("\nPor favor ingrese su area: ");
					area =int.Parse(Console.ReadLine());
					
					if (area !=1 & area !=2 & area !=3 & area !=4) {
						intentos = intentos + 1;
					}
					if (intentos == 2) {
						throw new ExcepcionArea(area);
					}
				}
				intentos = 0;
				Console.WriteLine("\nPor favor introduzca el legajo: ");
				legajo=int.Parse(Console.ReadLine());
				
				while (legajo < 0) {
					
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");					
					Console.WriteLine("\nPor favor introduzca el legajo: ");
					legajo=int.Parse(Console.ReadLine());
					
					if (legajo < 0) {intentos = intentos +1;}
					if (intentos == 2) {throw new ExcepcionNumLegajo(legajo);}
				}
				
				Tecnico nuevoTecnico = new Tecnico(nombre, apellido, documento, area,legajo);
				
				if (!vision.ExisteTecnico(nuevoTecnico)) {
					vision.AgregarTecnico(nuevoTecnico);
					Console.WriteLine("\nSe ingresaron correctamente los datos.");
				}else{throw new ExcepcionTecnicoExistente(nombre);}
				
			}catch(ExcepcionDocumento a){
				Console.WriteLine("\nEl numero de documento "+a.documento+" no es valido.");
				
			}catch(ExcepcionArea b){
				Console.WriteLine("\nEl numero de area "+b.numero+" no es valido.");
			
			}catch(ExcepcionNumLegajo c){
				Console.WriteLine("\nEl numero "+c.numero+" no es valido para el legajo.");
				
			}catch(ExcepcionTecnicoExistente d){
				Console.WriteLine("\nEl técnico "+d.nombre+" ya se encuentra trabajando en la empresa.");
				
			}
			catch (Exception e) {
				Console.WriteLine("\nSe ha producido el siguiente error: "+e.Message);
			}
		}
		
		public static void Facturar(Empresa vision){
			int numcliente;
			
			try {
				Console.WriteLine("\nPor favor introduzca el numero del cliente: ");
				numcliente = int.Parse(Console.ReadLine());
				
				int intentos = 0;
				
				while (numcliente < 0) {
					Console.WriteLine("\nValor ingresado no valido. Por favor vuelva a intentarlo.");
					
					Console.WriteLine("\nPor favor introduzca el numero del cliente: ");
					numcliente = int.Parse(Console.ReadLine());
					
					if (numcliente < 0) {
						intentos = intentos +1;						
					}
					if (intentos == 2) {
						throw new ExcepcionNumCliente(numcliente);						
					}
					
				}
				
				intentos = 0;
				
				Cliente clienteprueba = new Cliente();
				int cantidadclientes = vision.CantidadClientes();
				int clienteencontrado = 0;
				int costo=0;
				
				for (int i = 0; i < cantidadclientes; i++) {
					clienteprueba = vision.RecuperarCliente(i);
					
					if (clienteprueba.NumClienteSetGet == numcliente) {
						
						//Informamos al cliente los minutos consumidos que tiene el cliente.
						//Ya que si no fueron manipulados anteriormente queda en cero, es el valor prestablecido en la clase Cliente
						Console.WriteLine("\nLos minutos consumidos son {0} para el cliente dado.", clienteprueba.MinutosSetGet);
						
						Console.WriteLine("\nPresione 1 si desea modificar los minutos consumidos\n" +
						                  "o presione cualquier otro numero para facturar con los minutos dados: ");
						int opcion = int.Parse(Console.ReadLine());
						
						if (opcion == 1) {
							MinutosConsumidos(vision);
						}
						
						costo = clienteprueba.CostoSetGet;
						
						clienteencontrado=1;
						
						break;
						
					}
				}
				
				if (clienteencontrado == 1) {
					
					//LOS DETALLES A TENER EN CUENTA PARA LA FACTURACIÓN SON LOS SIGUIENTES:
					/* Combo 1 = 90 minutos libres y un costo de $80 por minuto de comunicación
					 * Combo 2 = 120 minutos libres y un costo de $120 por minuto de comunicación
					 * Combo 3 = 150 minutos libres y un costo de $180 por minuto de comunicación
					 * Combo 4 = 180 minutos libres y un costo de $220 por minuto de comunicación
					 */
					/*Como promoción aplica una bonificación mensual del 15% del costo del combo a aquellos
					 * clientes que hayan consumido menos del 85% de los minutos libres de su plan.
					 * Adicionalmente lanza una oferta por tiempo limitado (hasta una fecha dada)
					 * y con cupo restringido, de un combo PLUS que agrega el pack de fútbol y Disney Channel,
					 * a cada uno de los 4 combos, al mismo precio del combo original.
					 */
					
					int minutos_consumidos = 0, cuenta = 0;
					
					switch (costo) {
							
						case 80:
							// Combo 1 = 90 minutos libres y un costo de $80 por minuto de comunicación
							if (clienteprueba.MinutosSetGet > 90) {
								minutos_consumidos = (clienteprueba.MinutosSetGet) - 90;//Descontamos los 90 minutos libres.
							}else{
								minutos_consumidos = clienteprueba.MinutosSetGet;//Si los minutos consumidos son menor a 90
								//directamente queda asi.
							}
							//Multiplicamos los minutos por el costo por minuto.
							cuenta = minutos_consumidos * 80;
							
							if (clienteprueba.ComboExtraSetGet) {
								cuenta = cuenta*2;//A los que tienen el combo, se les cobra el paquete plus al mismo precio, por eso el por 2.
							}
							if (clienteprueba.MinutosSetGet < (clienteprueba.MinutosSetGet * 0.85)) {//Vemos si los minutos son menor al 85%
								cuenta=Convert.ToInt32( cuenta - (cuenta * 0.15));//Realizamos un descuento y un redondeo del precio.
							}
							Console.WriteLine("\nEl monto a abonar del cliente {0} son de {1} pesos.",clienteprueba.NombreSetGet, cuenta);							
							break;
							
						case 120:
							// Combo 2 = 120 minutos libres y un costo de $120 por minuto de comunicación
							
							if (clienteprueba.MinutosSetGet > 120) {
								minutos_consumidos = (clienteprueba.MinutosSetGet) - 120;
								
							}else{
								minutos_consumidos = clienteprueba.MinutosSetGet;//Si los minutos consumidos son menor a 120
								//directamente queda asi.
							}							
							cuenta = minutos_consumidos * 120;
							if (clienteprueba.ComboExtraSetGet) {
								cuenta = cuenta*2;//A los que tienen el combo, se les cobra el paquete plus al mismo precio, por eso el por 2.
							}
							if (clienteprueba.MinutosSetGet < (clienteprueba.MinutosSetGet * 0.85)) {
								
								cuenta=Convert.ToInt32( cuenta - (cuenta * 0.15));
								
							}
							Console.WriteLine("\nEl monto a abonar del cliente {0} son de {1} pesos.",clienteprueba.NombreSetGet, cuenta);
							break;
							
						case 180:
							//Combo 3 = 150 minutos libres y un costo de $180 por minuto de comunicación
							
							if (clienteprueba.MinutosSetGet > 150) {								
								minutos_consumidos = (clienteprueba.MinutosSetGet) - 150;
							}else{
								minutos_consumidos = clienteprueba.MinutosSetGet;
							}							
							cuenta = minutos_consumidos * 180;
							if (clienteprueba.ComboExtraSetGet) {
								cuenta = cuenta*2;							
							}
							
							if (clienteprueba.MinutosSetGet < (clienteprueba.MinutosSetGet * 0.85)) {								
								cuenta=Convert.ToInt32( cuenta - (cuenta * 0.15));								
							}							
							Console.WriteLine("\nEl monto a abonar del cliente {0} son de {1} pesos.",clienteprueba.NombreSetGet, cuenta);
							break;
							
						case 220:
							//Combo 4 = 180 minutos libres y un costo de $220 por minuto de comunicación
							
							if (clienteprueba.MinutosSetGet > 180) {
								minutos_consumidos = (clienteprueba.MinutosSetGet) - 180;								
							}else{
								minutos_consumidos = clienteprueba.MinutosSetGet;
							}
							
							cuenta = minutos_consumidos * 220;
							
							if (clienteprueba.ComboExtraSetGet) {								
								cuenta = cuenta*2;
							}
							if (clienteprueba.MinutosSetGet < (clienteprueba.MinutosSetGet * 0.85)) {								
								cuenta=Convert.ToInt32( cuenta - (cuenta * 0.15));								
							}
							Console.WriteLine("\nEl monto a abonar del cliente {0} son de {1} pesos.",clienteprueba.NombreSetGet, cuenta);
							break;
							
						default:
							throw new ExcepcionCosto(costo);							
					}
					
				}else{
					throw new ExcepcionClienteInexistente(numcliente);
				}
			}catch(ExcepcionNumCliente a){				
				Console.WriteLine("\nEl numero "+a.numero+" no es valido para el numero de cliente.");
				
			}catch(ExcepcionClienteInexistente c){
				Console.WriteLine("\nLo sentimos, no se encontró al cliente con el numero "+c.numero+".");
				
			}catch(ExcepcionCosto b){
				Console.WriteLine("\nLo sentimos, $"+b.numero+" no es un valor válido para el costo.");
			}
			catch (Exception x) {
				Console.WriteLine("\nSe ha producido el siguiente error: "+x.Message);
			}			
		}
		
		public static void ListadoTecnicos(Empresa vision){
			
			int cantidadtecnicos = vision.CantidadTecnicos();
			Tecnico tecnicoprueba;
			
			for (int i = 0; i < cantidadtecnicos; i++) {
				tecnicoprueba=vision.RecuperarTecnico(i);
				Console.WriteLine("\nNombre y Apellido : {0} {1}.\n" +
				                  "Documento : {2}.\n" +
				                  "Area : {3}.\n" +
				                  "Legajo : {4}.",tecnicoprueba.NombreSetGet, tecnicoprueba.ApellidoSetGet, tecnicoprueba.DocumentoSetGet, tecnicoprueba.AreaSetGet, tecnicoprueba.LegajoSetGet);
			}
		}
	}
}
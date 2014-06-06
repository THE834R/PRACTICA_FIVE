using System;
using MySql.Data.MySqlClient;

namespace Practica_6
{
	class Program
		{
			public static void Main(string[] args)
		{
			int opc = 5;
			int cont = 0;
			do{
				Console.WriteLine("\t Menú\n");
				Console.WriteLine("1) Ver\n");
            	Console.WriteLine("2) Agregar \n");
				Console.WriteLine("3) Editar\n");
 				Console.WriteLine("4) Eliminar\n");
 				Console.WriteLine("5) Salir\n");

 				opc = int.Parse( Console.ReadLine() );
 				Profesor profesor = new Profesor();
 				
 				switch( opc ){
 					case 1:
						profesor.mostrarTodos();
						break;	

					case 2:
						
						
						
						Console.WriteLine( "Ingresa el codigo " );
						String codigo = Console.ReadLine();
						Console.WriteLine( "Ingresa el nombre" );
						String nombre = Console.ReadLine();
						profesor.insertarRegistroNuevo(codigo,  nombre);

						break;

					case 3:

						Console.WriteLine( "Ingreesa el  ID del registro" );
						string id = Console.ReadLine();


						if(profesor.Buscarid( id )){
							Console.WriteLine( " codigo " );
							Console.WriteLine( " nombre" );
							Console.WriteLine("¿Seguro que desea editarlo?" );
							string dig = Console.ReadLine();
							if(dig == "s"){
								Console.WriteLine( "Dame el codigo " );
								codigo = Console.ReadLine();
								Console.WriteLine( "Dame el nombre" );
								nombre = Console.ReadLine();
								profesor.editarNombreCodigo( id, codigo,nombre);
							}
						}
						else{
							Console.WriteLine( "El id no existe " );
      						 Console.ReadLine();
							}

      						break;
      						
      						
      					case 4: 
      						Console.WriteLine( "Ingresa el  ID del registro" );
							 id = Console.ReadLine();
      						if(profesor.Buscarid(id )){
							 	codigo = Console.ReadLine();
								nombre = Console.ReadLine();

								Console.WriteLine("¿Seguro que desea eliminarlo?" );
								string dig = Console.ReadLine();
								if(dig == "s")
									profesor.eliminarRegistroPorId( id);
								}
							else{
								Console.WriteLine( "El id no existe presione cualquier tecla para continuar " );
      							 Console.ReadLine();
      							
							}

      						break;
      					case 5:
      						break;
 				
 				}
 				Console.WriteLine( "\tPresione cualquier tecla para continuar" );
      			Console.ReadLine();
      			
			}while( opc  < 5 );



		}
	}
}
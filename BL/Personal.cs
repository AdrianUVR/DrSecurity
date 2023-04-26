using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BL
{
    public class Personal
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.DrSecurityEntities context = new DL.DrSecurityEntities())
                {
                    var libro = context.PersonalesGetAll().ToList();
                    result.Objects = new List<object>();
                    if (libro != null)
                    {
                        foreach (var obj in libro)

                        {
                            ML.Personal personal = new ML.Personal();
                            personal.IdPersona = obj.IdPersona;
                            personal.Nombre = obj.Nombre;
                            personal.ApellidoPaterno = obj.ApellidoPaterno;
                            personal.ApellidoMaterno = obj.ApellidoMaterno;
                            personal.FechaNacimiento = (DateTime)obj.FechaNacimiento;
                            personal.sexo = obj.Sexo;
                            personal.EstadoNacimiento = obj.EstadoNacimiento;
                            personal.Telefono = obj.Telefono;
                            personal.DireccionActual = obj.DireccionActual;

                            personal.Direccion = new ML.Direccion();
                            personal.Direccion.IdDireccion = obj.IdDireccion;
                            personal.Direccion.EstadoOCiudad = obj.EstadoOCiudad;
                            personal.Direccion.DelegacionOMunicipio = obj.DelegacionOMunicipio;
                            personal.Direccion.Colonia = obj.Colonia;
                            personal.Direccion.Numero = (int)obj.Numero;

                            result.Objects.Add(personal);



                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros.";
                    }
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result Update(ML.Personal personal)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.DrSecurityEntities context = new DL.DrSecurityEntities())
                {
                    var query = context.PersonalesUpdate(personal.IdPersona, personal.Nombre, personal.ApellidoPaterno, personal.ApellidoMaterno,personal.FechaNacimiento,personal.sexo, personal.EstadoNacimiento, personal.Telefono, personal.DireccionActual);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se actualizo ningun registro";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result Add(ML.Personal personal)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.DrSecurityEntities context = new DL.DrSecurityEntities())
                {
                    var query = context.PersonalesAdd( personal.Nombre, personal.ApellidoPaterno, personal.ApellidoMaterno, personal.FechaNacimiento, personal.sexo, personal.EstadoNacimiento, personal.Telefono, personal.DireccionActual);


                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se agrego ningun registro";
                    }

                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result Delete(int IdPersona)
        {

            ML.Result result = new ML.Result();
            try
            {
                using (DL.DrSecurityEntities context = new DL.DrSecurityEntities())
                {
                    var query = context.PersonalDelete(IdPersona);
                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
                result.Correct = false;
            }
            return result;
        }



        public void CURP(ML.Personal personal)
        {
            string dos;
            string catorce;
            string quince;
            string dieciseis;
            char[] Nom = personal.Nombre.ToCharArray();
            char[] AP = personal.ApellidoPaterno.ToCharArray();
            char[] AM = personal.ApellidoMaterno.ToCharArray();
            string FN=personal.FechaNacimiento.ToString();
            char[] FeN=FN.ToCharArray();
            char[] vocales = "AEIOU".ToCharArray();

            char[] consonante= "BCDFGHJKLMÑPQRSTVXZ".ToCharArray() ;

            //int lenght1 = Nom.Length;
            //int lenght2 = AP.Length;
            //int lenght3 = AM.Length;

            //bool consonante_1 = false;
            //bool consonante_2 = false;
            //bool consonante_3 = false;

            string uno = AP[1].ToString();
            string tres= AM[1].ToString();
            string cuatro = Nom[1].ToString();
            string cinco = FeN[9].ToString(); //Año 05/03/1997
            string seis = FeN[10].ToString();
            string siete = FeN[4].ToString();
            string ocho = FeN[5].ToString();
            string nueve = FeN[1].ToString();
            string diez = FeN[2].ToString();

            string once = personal.sexo;
            string doce = personal.EstadoNacimiento;
            string trece = personal.EstadoNacimiento;

            
        


            for (int i = 1; i < AP.Length; i++)
            {
                for (int a = 0; a < vocales.Length; a++)
                {
                    if (AP[i] == vocales[a])
                    {
                        dos = AP[i].ToString();
                        break;
                    }
                }
            }

            for (int c =1; c < AP.Length; c++)
            {
                for (int b =0; b < consonante.Length; b++)
                {
                    if (AP[c]== consonante[b])
                    {
                        catorce= AP[c].ToString();
                        break;
                    }

                }
            }

            for (int d= 0; d < AM.Length; d++)
            {
                
                for (int c = 0; c < consonante.Length; c++)

                {
                    if (AM[d] == consonante[c])
                    {
                        quince= AM[d].ToString();   
                        break;
                    }


                }
            }

            for (int d = 0; d < Nom.Length; d++)
            {

                for (int c = 0; c < consonante.Length; c++)

                {
                    if (Nom[d] == consonante[c])
                    {
                        dieciseis = Nom[d].ToString();
                        break;
                    }


                }
            }



        }
    }
}

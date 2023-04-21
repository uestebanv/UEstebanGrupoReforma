using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Persona
    {
        public static ML.Result crud(ML.Persona persona)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.UEstebanGReformaEntities context = new DL.UEstebanGReformaEntities())
                {
                    var query = context.PersonaCRUD(persona.Accion,
                                                    persona.IdPersona,
                                                    persona.Nombre,
                                                    persona.Direccion,
                                                    persona.Edad,
                                                    persona.Correo,
                                                    persona.Habilidad1,
                                                    persona.Habilidad2,
                                                    persona.IdTipo);

                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.UEstebanGReformaEntities context = new DL.UEstebanGReformaEntities())
                {
                    var query = context.PersonaGetAll().ToList();

                    if (query != null)
                    {
                        foreach (var Item in query)
                        {
                            ML.Persona persona = new ML.Persona();
                            persona.IdPersona = Item.IdPersona;
                            persona.Nombre = Item.Nombre;
                            persona.Direccion = Item.Direccion;
                            persona.Edad = Item.Edad.Value;
                            persona.Correo = Item.Correo;
                            persona.Habilidad1 = Item.Habilidades;
                            persona.IdTipo = Item.IdTipo.Value;

                            result.Objects.Add(persona);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }

        public static ML.Result GetById()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.UEstebanGReformaEntities context = new DL.UEstebanGReformaEntities())
                {
                    var query = context.PersonaGetAll().FirstOrDefault();

                    if (query != null)
                    {
                        ML.Persona persona = new ML.Persona();
                        
                        persona.IdPersona   = query.IdPersona;
                        persona.Nombre      = query.Nombre;
                        persona.Direccion   = query.Direccion;
                        persona.Edad        = query.Edad.Value;
                        persona.Correo      = query.Correo;
                        persona.Habilidad1  = query.Habilidades;
                        persona.IdTipo      = query.IdTipo.Value;

                        result.Object = persona;


                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
            }
            return result;
        }
    }
}

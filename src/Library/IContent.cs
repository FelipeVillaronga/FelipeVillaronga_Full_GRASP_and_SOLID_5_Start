namespace Full_GRASP_And_SOLID;

public interface IContent
{
    string GetTextToPrint();
}

/// Aplicación de ISP, los Printers ya no son forzados a depender de Recipe, sino de esta interfaz, 
/// únicamente responsable del método GetTextToPrint, que es lo que utilizan los Printers de Recipe.
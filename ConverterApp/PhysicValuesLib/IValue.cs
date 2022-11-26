namespace PhysicValuesLib;


public interface IValue
{
    
    Dictionary<string, double> ConvertationCoefficient();

    string GetValueName();
    
    List<string> GetMeasureList();

   
    double GetConvertedValue(double value, string from, string to);

   
    void ToSi();

    void ToRequired();
}

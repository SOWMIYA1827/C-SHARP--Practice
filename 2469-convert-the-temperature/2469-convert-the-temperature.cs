public class Solution {
    public double[] ConvertTemperature(double celsius) {
        double kelvin = celsius + 273.15 ;
        double fahren = celsius * 1.80 + 32.00 ;

        double[] arr = new double[2];
        arr[0] = kelvin;
        arr[1] = fahren;

        return arr;

    }
}
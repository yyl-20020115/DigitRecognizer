using System.Collections.Generic;

namespace MLParser.Types;

/// <summary>
/// Data-type for holding machine learning data from a csv file, consisting of an array of doubles (input) and a label (output).
/// </summary>
public class MLData
{
    /// <summary>
    /// Input
    /// </summary>
    public List<double> Data = new();
    /// <summary>
    /// Output
    /// </summary>
    public int Label = 0;
}

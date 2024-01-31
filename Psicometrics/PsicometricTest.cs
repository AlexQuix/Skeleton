using Psicometrics.Abstract;
using Psicometrics.Tests.DOMINO;
using Psicometrics.Tests.OTIS;

namespace Psicometrics;

public static class PsicometricTest
{
    private static Dictionary<TestType, ITest> _testDictionary;
    public static ITest OTIS { get; private set; }
    public static ITest DOMINO { get; private set; }

    static PsicometricTest()
    {
        OTIS = new OTISTest();
        DOMINO = new DominoTest();

        _testDictionary = new Dictionary<TestType, ITest>
        {
            { TestType.OTIS, OTIS },
            { TestType.DOMINO, DOMINO }
        };
    }

    public static TestResult CalculteResult( object aswers, TestType testType )
    {
        if( !_testDictionary.ContainsKey( testType ) )
            throw new TestException( "Test seleccionado es invalido" );

        return _testDictionary[testType].CalculateResult(aswers);
    }
}
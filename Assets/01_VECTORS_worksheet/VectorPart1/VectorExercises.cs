using UnityEngine;

public class VectorExercises : MonoBehaviour
{
    [SerializeField] LineFactory lineFactory;
    [SerializeField] bool Q2a, Q2b, Q2c, Q2d, Q2e;
    [SerializeField] bool Q3a, Q3b, Q3c, projection;

    private Line drawnLine;

    private Vector2 startPt;
    private Vector2 endPt;

    public float GameWidth, GameHeight;
    private float minX, minY, maxX, maxY;

    private void Start()
    {
        CalculateGameDimensions();

        if (Q2a)
            Question2a();
        if (Q2b)
            Question2b(20);

        if (Q2c)
            Question2c(20);

        if (Q2d)
            Question2d();
        if (Q2e)
            Question2e(20);
        if (Q3a)
            Question3a();
        if (Q3b)
            Question3b();
        if (Q3c)
            Question3c();
        if (projection)
            Projection();
    }

    public void CalculateGameDimensions()
    {
        GameHeight = Camera.main.orthographicSize * 2f;
        GameWidth = Camera.main.aspect * GameHeight;

        maxX = GameWidth / 2;
        maxY = GameHeight / 2;
        minX = -maxX;
        minY = -maxY;
    }

    void Question2a()
    {
        startPt = new Vector2(-1, -5);
        endPt = new Vector2(4, 5);

        drawnLine = lineFactory.GetLine(startPt, endPt, 0.02f, Color.black);

        drawnLine.EnableDrawing(true);

        Vector2 vec2 = endPt - startPt;
        Debug.Log("Magnitude = " + vec2.magnitude);
    }

    void Question2b(int n)
    {
        for (int i = 0; i < n; i ++)
        {
            Vector2 startPt = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            Vector2 endPt = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));

            drawnLine = lineFactory.GetLine(startPt, endPt, 0.02f, Color.black);

            drawnLine.EnableDrawing(true);
        }
    }

    void Question2c(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Vector2 startPt = new Vector2(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY));
            Vector2 endPt = new Vector2(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY));

            drawnLine = lineFactory.GetLine(startPt, endPt, 0.02f, Color.black);

            drawnLine.EnableDrawing(true);
        }
    }

    void Question2d()
    {
        DebugExtension.DebugArrow(new Vector3(0, 0, 0), new Vector3(5, 5, 0), Color.red, 60f); //60f = 60 seconds
    }

    void Question2e(int n)
    {
        for (int i = 0; i < n; i++)
        {
            startPt = new Vector2(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY));


            // Your code here
            Vector2 endPt = new Vector2(Random.Range(-maxX, maxX), Random.Range(-maxY, maxY));
            DebugExtension.DebugArrow(new Vector3(0, 0, 0), new Vector3(endPt.x, endPt.y, Random.Range(-maxY, maxY)), Color.white, 60f); // Reuse -maxY, maxY for Z Axis


            
        }  
    }

    public void Question3a()
    {
        HVector2D a = new HVector2D(3, 5);
        HVector2D b = new HVector2D(-4, 2);
        HVector2D c = new HVector2D(a.x + b.x, a.y + b.y);

        // Your code here
        DebugExtension.DebugArrow(Vector3.zero, a.ToUnityVector3(), Color.red, 60f);
        DebugExtension.DebugArrow(Vector3.zero, b.ToUnityVector3(), Color.green, 60f);
        DebugExtension.DebugArrow(Vector3.zero, c.ToUnityVector3(), Color.white, 60f);

        // Your code here
        DebugExtension.DebugArrow(b.ToUnityVector3(), (b.ToUnityVector3() + c.ToUnityVector3()), Color.white, 60f);

        // Q3a a minus b

        DebugExtension.DebugArrow(a.ToUnityVector3(), (a.ToUnityVector3() - b.ToUnityVector3()), Color.yellow, 60f);
        

        // Your code here
        float MagnitudeA = a.Magnitude();
        Debug.Log("Magnitude of a = " + MagnitudeA.ToString("F2"));   //F2 2 decimal point      // Your code here.ToString("F2"));

        float MagnitudeB = b.Magnitude();
        Debug.Log("Magnitude of b = " + MagnitudeB.ToString("F2"));

        float MagnitudeC = c.Magnitude();
        Debug.Log("Magnitude of c = " + MagnitudeC.ToString("F2"));
    }

    public void Question3b()
    {
        // Your code here
        HVector2D a = new HVector2D(3, 5);
        HVector2D b = new HVector2D(a.x * 2, a.y * 2);

        DebugExtension.DebugArrow(Vector3.zero, a.ToUnityVector3(), Color.red, 60f);
        DebugExtension.DebugArrow(new Vector3(1, 0, 0), b.ToUnityVector3(), Color.green, 60f);
        // Your code here
    }

    public void Question3c()
    {

    }

    public void Projection()
    {
        HVector2D a = new HVector2D(0, 0);
        HVector2D b = new HVector2D(6, 0);
        HVector2D c = new HVector2D(2, 2);

        //HVector2D v1 = b - a;
        // Your code here

        //HVector2D proj = // Your code here

        //DebugExtension.DebugArrow(a.ToUnityVector3(), b.ToUnityVector3(), Color.red, 60f);
        //DebugExtension.DebugArrow(a.ToUnityVector3(), c.ToUnityVector3(), Color.yellow, 60f);
        //DebugExtension.DebugArrow(a.ToUnityVector3(), proj.ToUnityVector3(), Color.white, 60f);
    }
}

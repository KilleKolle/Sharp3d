namespace Sharp3d;

public readonly struct Vector3
{
    public readonly float X;
    public readonly float Y;
    public readonly float Z;

    public Vector3(float x, float y, float z)
    {
        //not using school xyz :(
        this.X = x;
        this.Y = y;
        this.Z = z;
    }

    public static Vector3 operator +(Vector3 vecLeft, Vector3 vecRight)
    {
        //a+b -> a1+b1 a2+b2 etc
        return new Vector3(vecLeft.X + vecRight.X, vecLeft.Y + vecRight.Y, vecLeft.Z + vecRight.Z);
    }
    
    public static Vector3 operator -(Vector3 vecLeft, Vector3 vecRight)
    {
        //a-b same as above
        return new Vector3(vecLeft.X - vecRight.X, vecLeft.Y - vecRight.Y, vecLeft.Z - vecRight.Z);
    }

    public static Vector3 operator *(Vector3 vecLeft, float number)
    {
        //Skalarmultiplication
        return new Vector3(vecLeft.X * number, vecLeft.Y * number, vecLeft.Z * number);
    }
    
    public static Vector3 operator *(Vector3 vecLeft, Vector3 vecRight)
    {
        //vec*vec
        return new Vector3(vecLeft.X * vecRight.X, vecLeft.Y * vecRight.Y, vecLeft.Z * vecRight.Z);
    }
    
    public static Vector3 operator /(Vector3 vecLeft, float number)
    {
        //vec/number, vec/vec not possible?
        return new Vector3(vecLeft.X / number, vecLeft.Y / number, vecLeft.Z / number);
    }

    public static float VectorGetLength(Vector3 vec)
    {
        //sqrt from (x*x)+(y*y) etc.
        return MathF.Sqrt((vec.X*vec.X)+(vec.Y*vec.Y)+(vec.Z*vec.Z));
    }


    public static Vector3 NormaliseVector(Vector3 vec)
    {
        //cant normalise that? just returning vec?
        if (vec.X == 0 && vec.Y == 0 && vec.Z == 0) return vec;
        
        //new vec length 1 -> x/length, y/length etc
        float length = VectorGetLength(vec);
        return vec / length;
    }

    public static float CalculateVecDistance(Vector3 vecLeft, Vector3 vecRight)
    {
        return MathF.Sqrt((vecLeft.X - vecRight.X) * (vecLeft.X - vecRight.X)
                          + (vecLeft.Y - vecRight.Y) * (vecLeft.Y - vecRight.Y)
                          + (vecLeft.Z - vecRight.Z) * (vecLeft.Z - vecRight.Z));
    }
    
    //returns coords as readable String
    public override string ToString()
    {
        return "x: "+X+"; y: "+Y+"; z: "+Z;
    }
    
}
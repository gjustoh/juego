using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public abstract class Object{
    public abstract string Name {get;}

    public abstract void CreateObject();
} 
public class BañoObject:  Object{
    public override string Name =>"Baño";
    
    public override void CreateObject(){

    }

}
public class SalaObject:  Object{
        public override string Name =>"Sala";

    // Start is called before the first frame update
    public override void CreateObject(){

    }

}
public class CuartoObject:  Object{
        public override string Name =>"Cuarto";

    // Start is called before the first frame update
    public override void CreateObject(){

    }

}
public class  CocinaObject:  Object{
        public override string Name =>"Cocina";

    // Start is called before the first frame update
    public override void CreateObject(){

    }

}
public class  AlcobaObject:  Object{
    public override string Name =>"Alcoba";

    // Start is called before the first frame update
    public override void CreateObject(){

    }

}
public class ObjectFactory{

    public Object GetObject(string entorno){

        switch (entorno)
        {  
            case "baño":
                return new BañoObject();
            case "sala":
                return new SalaObject();
            case "cuarto":
                return new CuartoObject();
            case "cocina":
                return new CocinaObject();
            case "alcoba":
                return new AlcobaObject();
            default:
                return null;
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comosits : Component 
{
    [SerializeField]List<Component> child = new List<Component>();
    [SerializeField]public Comosits(string name) : base(name)
    {

    }

   

    public void Add(Component c)
    {
        child.Add(c);
    }
    public void remove(Component c)
    {
        child.Remove(c);

    }

    public void Display(int depth)
    {
        foreach (var item in child)
        {
            item.Display(depth);
        }
    }

    
}

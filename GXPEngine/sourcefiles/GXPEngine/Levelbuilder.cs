using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using GXPEngine;
class Levelbuilder
{
    public List<int> level = new List<int>();

    public void Start()
    {
        if (File.Exists("LevelOne.xml"))
        {
            LevelDataHolder dat = Loading();
            level = dat.level;
        }
        else
        {
            var serializer = new XmlSerializer(typeof(LevelDataHolder));
            using (var stream = new FileStream("LevelOne.xml", FileMode.Create))
            {
                //serializer.Serialize(stream, dataHolder);
            }
        }
    }
    public LevelDataHolder Loading()
    {
        var serializer = new XmlSerializer(typeof(LevelDataHolder));
        using (var stream = new FileStream("LevelOne.xml", FileMode.Open))
        {
            return serializer.Deserialize(stream) as LevelDataHolder;
        }
    }
    
}

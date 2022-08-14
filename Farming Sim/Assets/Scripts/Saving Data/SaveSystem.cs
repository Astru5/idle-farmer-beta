using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveInventory (Inventory inventory)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.bru";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(inventory);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadData()
    {
        string path = Application.persistentDataPath + "/player.bru";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}

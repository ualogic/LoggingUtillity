/////////////////////////////////////////////////////////
///////////////////Logging Utilities/////////////////////
/////////////////By Vitaliy Tyzhnevyy////////////////////
/////////////////////////////////////////////////////////
//Debug log and debug text field log//
//////////////////////////////////////
using System.Text;
using UnityEngine;

public static class u
{
    /// <summary>
    /// Adds the string to the debug text field.
    /// </summary>
    public static object d {set{debug(value);}}

    /// <summary>
    /// Logs the string to the console. Uses Debug.Log().
    /// </summary>
    public static object l {set{log(value);}}

    /// <summary>
    /// Logs all the comma separated values separated by space. Uses ToString(), String Builder and Debug.Log.
    /// </summary>
    /// <param name="any">Any value to output to Debug console</param>
    public static void log(params object[] log){

        StringBuilder str = new StringBuilder();
        int len = log.Length - 1;

        for(int i = 0; i <= len; i++){
            str.Append(log[i].ToString());
            if(i < len) str.Append(" ");
        }

        Debug.Log(str);

    }

    /// <summary>
    /// Logs all the comma separated values separated with separator. Uses ToString(), String Builder and Debug.Log.
    /// </summary>
    /// <param name="Separator">String separator</param>
    /// <param name="any">Any value to output to Debug console</param>
    public static void slog(string separator, params object[] log){

        StringBuilder str = new StringBuilder();
        int len = log.Length - 1;

        for(int i = 0; i <= len; i++){
            str.Append(log[i].ToString());
           if(i < len) str.Append(separator);
        }

        Debug.Log(str);

    }

    /// <summary>
    /// Adds all the comma separated values to the debug text field. Separates with spaces. Uses ToString(), String Builder and DataManager.instance.DebugText.
    /// </summary>
    /// <param name="any">Any value to output to Debug console</param>
    public static void debug(params object[] log){

        StringBuilder str = new StringBuilder();
        int len = log.Length - 1;

        for(int i = 0; i <= len; i++){
            if(log[i] == null){
                str.Append("null");
            }else{
                str.Append(log[i].ToString());
            }
            if(i < len) str.Append(" ");
        }

        ///////////////////////Text Field///////////////////////
        DataManager.instance.DebugText.text += "\r\n" + str;
    }
}


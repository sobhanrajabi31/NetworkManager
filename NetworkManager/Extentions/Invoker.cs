using System;
using System.Windows.Forms;

internal static class invoker
{
    public static void Invoker(this Control control, Action act)
    {
        control.Invoke(new MethodInvoker(act), null);
    }
}

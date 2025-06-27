using System.Drawing.Imaging;

public static class ScreenshotsGenerator
{
    private static string TrimEnd(this string source, string value)
    {
        if (!source.EndsWith(value))
            return source;

        return source.Remove(source.LastIndexOf(value));
    }

    public static void Generate(MainForm frm)
    {
        var dir = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(typeof(ScreenshotsGenerator).Assembly.Location), "WinformsScreenshots"));

        if (dir.Exists) dir.Delete(true);
        dir.Create();

        foreach (TreeNode node in frm.leftTreeView.Nodes)
        {
            frm.leftTreeView.SelectedNode = node;
            frm.SelectNode(node);

            var bm = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(bm, new Rectangle(0, 0, bm.Width, bm.Height));
            bm.Save(Path.Combine(dir.FullName, node.Tag.GetType().Name.TrimEnd("Control") + ".jpg"), ImageFormat.Jpeg);
        }

        Explorer.OpenDirectory(dir.FullName);
    }
}


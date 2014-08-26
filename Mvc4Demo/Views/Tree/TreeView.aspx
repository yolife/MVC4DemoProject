<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Tree View</title>
    <script src="http://code.jquery.com/jquery-1.9.1.min.js"></script>
    <script type="text/javascript">

        var GetDepth = function (root) {
            var $parent = $(root).parents('ul');
            var depth = 0;
            while ($parent.length > 0) {
                $parent = $parent.parents('ul');
                depth += 1;
            }
            return depth;
        };


        var hideNodes = function (maxDepth) {
            var root = $("ul");
            $(root.children('li')).each(function () {
                var Me = $(this);
                if (GetDepth(Me.parent()) == maxDepth) {
                    Me.hide();
                }
                if (Me.children('ul').length > 0) {
                    var root = Me.children('ul');
                    hideNodes(maxDepth);
                }
            });
        };

    </script>
</head>
<body>
    Show Treeview till the depth
    <%: ViewBag.TreeDepth %>
    <div>
        <%
            Action<List<Mvc4Demo.Models.TreeNode>, int> RecursiveTraversal = null;
            RecursiveTraversal = (List<Mvc4Demo.Models.TreeNode> nodes, int depth) =>
            {
                if (nodes == null || nodes.Count == 0) return;
        %>
        <ul>
            <%
                foreach (Mvc4Demo.Models.TreeNode node in nodes)
                {
            %>
            <li>
                <%=node.Name%>
                <%RecursiveTraversal(node.Children, depth + 1);%>
            </li>
            <%
                }
            %>
        </ul>
        <%
            };

            RecursiveTraversal(ViewBag.TreeData, 0);
        %>
    </div>
</body>

<script type="text/javascript">
    $(document).ready(function () {
        var depth = <%=ViewBag.TreeDepth%>;
        hideNodes(depth);
    });
</script>
</html>


// This file has been generated by the GUI designer. Do not modify.
namespace JiraAssistant.Mono
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.Action JiraAction;

		private global::Gtk.Action LoginAction;

		private global::Gtk.Action LogoutAction;

		private global::Gtk.Table table1;

		private global::JiraAssistant.Mono.AuthControlWidget authControlWidget;

		private global::JiraAssistant.Mono.StatusBarWidget statusBarWidget;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget JiraAssistant.Mono.MainWindow
			this.UIManager = new global::Gtk.UIManager();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
			this.JiraAction = new global::Gtk.Action("JiraAction", global::Mono.Unix.Catalog.GetString("Jira"), null, null);
			this.JiraAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Jira");
			w1.Add(this.JiraAction, null);
			this.LoginAction = new global::Gtk.Action("LoginAction", global::Mono.Unix.Catalog.GetString("Login"), null, null);
			this.LoginAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Login");
			w1.Add(this.LoginAction, null);
			this.LogoutAction = new global::Gtk.Action("LogoutAction", global::Mono.Unix.Catalog.GetString("Logout"), null, null);
			this.LogoutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Logout");
			w1.Add(this.LogoutAction, null);
			this.UIManager.InsertActionGroup(w1, 0);
			this.AddAccelGroup(this.UIManager.AccelGroup);
			this.Name = "JiraAssistant.Mono.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString("Jira Assistant");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child JiraAssistant.Mono.MainWindow.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(1)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.authControlWidget = new global::JiraAssistant.Mono.AuthControlWidget();
			this.authControlWidget.WidthRequest = 0;
			this.authControlWidget.HeightRequest = 0;
			this.authControlWidget.Events = ((global::Gdk.EventMask)(256));
			this.authControlWidget.Name = "authControlWidget";
			this.authControlWidget.IsLoginControlVisible = false;
			this.authControlWidget.IsContentDisplayVisible = false;
			this.table1.Add(this.authControlWidget);
			// Container child table1.Gtk.Table+TableChild
			this.statusBarWidget = new global::JiraAssistant.Mono.StatusBarWidget();
			this.statusBarWidget.Events = ((global::Gdk.EventMask)(256));
			this.statusBarWidget.Name = "statusBarWidget";
			this.table1.Add(this.statusBarWidget);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.statusBarWidget]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.table1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 464;
			this.Show();
		}
	}
}

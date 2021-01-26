using System.Windows.Input;
using System.Windows;
using ChatClientCS.ViewModels;
using System.Collections.Generic;
using ChatClientCS.TreeViewS;
using TreeViewS;

namespace ChatClientCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow 
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (Tg_Btn.IsChecked == true)
            {
                tt_home.Visibility = Visibility.Collapsed;
                tt_contacts.Visibility = Visibility.Collapsed;
                tt_messages.Visibility = Visibility.Collapsed;
                tt_maps.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_home.Visibility = Visibility.Visible;
                tt_contacts.Visibility = Visibility.Visible;
                tt_messages.Visibility = Visibility.Visible;
                tt_maps.Visibility = Visibility.Visible;

            }
        }

        private void HouseView_Clicked(object sender, RoutedEventArgs e)
        {
            
        }

                       
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<Project> projects = new List<Project>();
           
                Project pt = new Project() { Name = "IT"};
                pt.types = new Types() { Name = "Types", projectType = new List<ProjectType>() };
             
                    pt.types.projectType.Add(new ProjectType() { Name = "Type"  });                
                pt.instances = new Instances() { Name = "Instances", projectInstance = new List<ProjectInstance>() };
               
                    pt.instances.projectInstance.Add(new ProjectInstance() { Name = "Instances" });
                
                projects.Add(pt);

            Project pt1 = new Project() { Name = "Design" };
            pt1.types = new Types() { Name = "Types", projectType = new List<ProjectType>() };
           
                pt1.types.projectType.Add(new ProjectType() { Name = "Type" });
            
            pt1.instances = new Instances() { Name = "Instances", projectInstance = new List<ProjectInstance>() };
            
                pt1.instances.projectInstance.Add(new ProjectInstance() { Name = "Instances"});
          
            projects.Add(pt1);

            List<Wrapper> wrappers = new List<Wrapper>();
            foreach (var item in projects)
            {
                wrappers.Add(new Wrapper() { Item = item });
            }
            tvProjects.ItemsSource = wrappers;
        }

        private void ButtonAddItem(object sender, RoutedEventArgs e)
        {
         
        }
    }
}

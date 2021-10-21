using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Dal.Abstract;
using Dal.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BoardManager>().As<IBoardService>().SingleInstance();
            builder.RegisterType<EfBoardDal>().As<IBoardDal>().SingleInstance();

            builder.RegisterType<BoardTaskManager>().As<IBoardTaskService>().SingleInstance();
            builder.RegisterType<EfBoardTaskDal>().As<IBoardTaskDal>().SingleInstance();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>().SingleInstance();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>().SingleInstance();

            builder.RegisterType<FailedTasksManager>().As<IFailedTasksService>().SingleInstance();
            builder.RegisterType<EfFailedTasksDal>().As<IFailedTasksDal>().SingleInstance();

            builder.RegisterType<MailSettingsManager>().As<IMailSettingsService>().SingleInstance();
            builder.RegisterType<EfMailingSettingsDal>().As<IMailSettingsDal>().SingleInstance();

            builder.RegisterType<MailTemplatesManager>().As<IMailTemplatesService>().SingleInstance();
            builder.RegisterType<EfMailTemplatesDal>().As<IMailTemplatesDal>().SingleInstance();

            builder.RegisterType<MilestoneManager>().As<IMilestoneService>().SingleInstance();
            builder.RegisterType<EfMilestoneDal>().As<IMilesStoneDal>().SingleInstance();

            builder.RegisterType<PersonManager>().As<IPersonService>().SingleInstance();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>().SingleInstance();

            builder.RegisterType<ProjectManager>().As<IProjectService>().SingleInstance();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>().SingleInstance();

            builder.RegisterType<ProjectLeaderManager>().As<IProjectLeaderService>().SingleInstance();
            builder.RegisterType<EfProjectLeaderDal>().As<IProjectLeaderDal>().SingleInstance();

            builder.RegisterType<ProjectPersonManager>().As<IProjectPersonService>().SingleInstance();
            builder.RegisterType<EfProjectPersonDal>().As<IProjectPersonDal>().SingleInstance();

            builder.RegisterType<RoleManager>().As<IRoleService>().SingleInstance();
            builder.RegisterType<EfRoleDal>().As<IRoleDal>().SingleInstance();

            builder.RegisterType<SprintManager>().As<ISprintService>().SingleInstance();
            builder.RegisterType<EfSprintDal>().As<ISprintDal>().SingleInstance();

            builder.RegisterType<TaskBudgetManager>().As<ITaskBudgetService>().SingleInstance();
            builder.RegisterType<EfTaskBudgetDal>().As<ITaskBudgetDal>().SingleInstance();

            builder.RegisterType<TaskCommentManager>().As<ITaskCommentService>().SingleInstance();
            builder.RegisterType<EfTaskCommentDal>().As<ITaskCommentDal>().SingleInstance();           

            builder.RegisterType<TaskFileManager>().As<ITaskFileService>().SingleInstance();
            builder.RegisterType<EfTaskFileDal>().As<ITaskFileDal>().SingleInstance();

            builder.RegisterType<TaskPersonDetailManager>().As<ITaskPersonDetailService>().SingleInstance();
            builder.RegisterType<EfTaskPersonDetailDal>().As<ITaskPersonDetailDal>().SingleInstance();

            builder.RegisterType<TaskPersonManager>().As<ITaskPersonService>().SingleInstance();
            builder.RegisterType<EfTaskPersonDal>().As<ITaskPersonDal>().SingleInstance();

            builder.RegisterType<TaskManager>().As<ITaskService>().SingleInstance();
            builder.RegisterType<EfTaskDal>().As<ITaskDal>().SingleInstance();

            builder.RegisterType<TeamManager>().As<ITeamService>().SingleInstance();
            builder.RegisterType<EfTeamDal>().As<ITeamDal>().SingleInstance();

            builder.RegisterType<WaitingMailsManager>().As<IWaitingMailsService>().SingleInstance();
            builder.RegisterType<EfWaitingMailsDal>().As<IWaitingMailsDal>().SingleInstance();




            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

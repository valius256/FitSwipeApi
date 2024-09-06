using System.Linq.Expressions;

namespace FitSwipe.SchedulerJobs
{
    public interface IDefaultScheduleJob
    {
        string Enqueue<T>(Expression<Action<T>> methodCall);
    }
}

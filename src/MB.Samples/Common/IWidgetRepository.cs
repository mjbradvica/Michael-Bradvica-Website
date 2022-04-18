namespace MB.Samples.Common
{
    public interface IWidgetRepository
    {
        Task<Widget> GetWidget(Guid id);
    }
}

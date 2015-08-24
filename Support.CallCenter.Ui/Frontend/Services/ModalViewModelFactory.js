var ModalViewModelFactory = function ()
{
    var modalViewModel = function ()
    {
        this.IsVisible = false;
    };

    modalViewModel.prototype.Show = function ()
    {
        this.IsVisible = true;
    };

    modalViewModel.prototype.Hide = function ()
    {
        this.IsVisible = false;
    };


    var getInstance = function ()
    {
        var modal = new modalViewModel();
        return modal;
    }

    var factory =
        {
            GetInstance: getInstance
        };

    return factory;
}
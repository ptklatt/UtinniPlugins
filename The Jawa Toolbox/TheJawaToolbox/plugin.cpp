#include <mscoree.h>

#include "UtinniCore/utinni.h"
#include "UtinniCore/plugin_framework/utinni_plugin.h"
#include "UtinniCore/swg/ui/cui_chat_window.h"

#include "swg/ui/tjt_command_parser.h"

class TheJawaToolboxPlugin : public utinni::UtinniPlugin
{
private:
    Information information =
    {
        "The Jawa Toolbox",
        "An SWG Client development toolbox",
        "Timbab"
    };

public:
    TheJawaToolboxPlugin()
    {
        utinni::CuiChatWindow::addCreateCommandParserCallback(&tjt::TheJawaToolboxCommandParser::create);
    }

    ~TheJawaToolboxPlugin()
    {

    }

    virtual void init() override
    {
    }

    virtual const Information& getInformation() const override
    {
        return information;
    }
};

extern "C"
{
    UTINNI_PLUGIN
    {
        return new TheJawaToolboxPlugin();
    }
}
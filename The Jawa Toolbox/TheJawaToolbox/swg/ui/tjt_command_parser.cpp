#include "tjt_command_parser.h"


namespace tjt
{
static const utinni::CommandParser::CommandData commands[] =
{
    {"", 0, "", ""},
};

TheJawaToolboxCommandParser::TheJawaToolboxCommandParser() : utinni::CommandParser("tjt", 0, "...", "The Jawa Toolbox related commands.", nullptr)
{
    for (const auto& command : commands)
    {
        addSubCommand(utinni::swg_new<CommandParser>(command, this));
    }
}

bool TheJawaToolboxCommandParser::performParsing(const int64_t& userId, const std::vector<swg::WString>& args, const wchar_t* originalCommand, const wchar_t* result, const CommandParser* node)
{
    auto& cmd = args[0];

    if (cmd == "")
    {
        return true;
    }

    return false;
}

void TheJawaToolboxCommandParser::create(CommandParser* mainCommandParser)
{
    mainCommandParser->addSubCommand(utinni::swg_new<TheJawaToolboxCommandParser>());
}
}

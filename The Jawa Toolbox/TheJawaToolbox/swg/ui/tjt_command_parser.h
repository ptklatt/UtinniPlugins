#pragma once

#include "UtinniCore/utinni.h"
#include "UtinniCore/swg/misc/swg_string.h"
#include "UtinniCore/swg/ui/command_parser.h"

namespace tjt
{
class UTINNI_API TheJawaToolboxCommandParser : public utinni::CommandParser
{
public:
    TheJawaToolboxCommandParser();
    bool performParsing(const int64_t& userId, const std::vector<swg::WString>& args, const wchar_t* originalCommand, const wchar_t* result, const CommandParser* node) override;
    static void create(CommandParser* mainCommandParser);;
};
}
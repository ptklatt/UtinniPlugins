/**
 * MIT License
 *
 * Copyright (c) 2020 Philip Klatt
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
**/

#include "tjt_command_parser.h"
#include "UtinniCore/swg/game/game.h"
#include "UtinniCore/swg/scene/ground_scene.h"
#include "UtinniCore/swg/scene/terrain.h"
#include "UtinniCore/swg/scene/world_snapshot.h"
#include "UtinniCore/swg/object/player_object.h"
#include "UtinniCore/swg/ui/cui_misc.h"


namespace tjt
{
static const utinni::CommandParser::CommandData commands[] =
{
    {"cam", 0, "", "Toggles the FreeCamera."},
    {"player", 0, "", "Toggles visibility of the player."},
    {"reloadSnapshot", 0, "", "Reloads the .WS file and its nodes."},
    {"reloadTerrain", 0, "", "Reloads the terrain."},
    {"reloadUI", 0, "", "Reloads the interface."},
    {"speed", 1, "<float>", "Sets the player speed."},
    {"teleport", 2, "<x> <y>", "Teleport to the given position."},
    {"tod", 1, "<float>", "Sets the time of day."},
    {"weather", 1, "<id>", "Changes the weather to that of the given id."},
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

    if (cmd == "cam")
    {
        utinni::GroundScene::get()->toggleFreeCamera();
        return true;
    }

    if (cmd == "player")
    {
        utinni::playerObject::togglePlayerAppearance();
        return true;
    }

    if (cmd == "speed")
    {
        utinni::playerObject::setSpeed(std::atof(args[1].toString().c_str()));
        return true;
    }

    if (cmd == "teleport")
    {
        const float x = std::atof(args[1].toString().c_str());
        const float y = std::atof(args[2].toString().c_str());
        utinni::playerObject::teleport(x, 0, y); // in SWG's system, the Y is the actual Z
        return true;
    }

    if (cmd == "reloadTerrain")
    {
        utinni::GroundScene::get()->reloadTerrain();
        return true;
    }

    if(cmd == "reloadSnapshot")
    {
        utinni::WorldSnapshot::reload();
        return true;
    }

    if (cmd == "reloadUI")
    {
        utinni::cuiMisc::reloadUi();
        return true;
    }

    if (cmd == "tod")
    {
        utinni::Terrain::get()->setTimeOfDay(std::atof(args[1].toString().c_str()));
        return true;
    }

    if (cmd == "weather")
    {
        utinni::Terrain::get()->setWeatherIndex(std::atoi(args[1].toString().c_str()));
        return true;
    }

    return false;
}

void TheJawaToolboxCommandParser::create(CommandParser* mainCommandParser)
{
    mainCommandParser->addSubCommand(utinni::swg_new<TheJawaToolboxCommandParser>());
}
}

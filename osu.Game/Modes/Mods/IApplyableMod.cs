﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE


using osu.Game.Modes.Objects;
using osu.Game.Modes.UI;

namespace osu.Game.Modes.Mods
{
    /// <summary>
    /// An interface for mods that are applied to a HitRenderer.
    /// </summary>
    /// <typeparam name="TObject">The type of HitObject the HitRenderer contains.</typeparam>
    public interface IApplyableMod<TObject>
        where TObject : HitObject
    {
        /// <summary>
        /// Applies the mod to a HitRenderer.
        /// </summary>
        /// <param name="hitRenderer">The HitRenderer to apply the mod to.</param>
        void Apply(HitRenderer<TObject> hitRenderer);

        /// <summary>
        /// Reverts any changes applied to a HitRenderer through <see cref="Apply(HitRenderer{TObject})"/>.
        /// </summary>
        /// <param name="hitRenderer">The HitRenderer to revert from.</param>
        void Revert(HitRenderer<TObject> hitRenderer);
    }
}

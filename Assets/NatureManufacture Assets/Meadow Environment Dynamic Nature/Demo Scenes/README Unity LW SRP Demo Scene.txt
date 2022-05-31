Unity Standard Demo Scene

Info about  SRP:
This demo "Unity LW SRP Demo Scene" work with unity LW SRP 4.3+ or 4.6+

How to run it:
- open demo scene 
- regenerate light in lighting window
- change anisotropy in window -> project settings -> Quality --> anisotropic textures -> forced on 
- change v sync to check fps in window -> project settings -> Quality --> V sync Count to Dont sync
- click play
- play with directional light angle at x = 40 it looks pretty nice.
- change shadow distance to 500 or higher in LWRP-HighQuality or others file in your project.
- play with wind prefab and wind speed:)


How we build it?
1) create terrain shape via Gaia with our stamps.
2) paint terrain automaticly via slopes:
   * grass on flat area
   * dirt/dry ground on small slopes
3) paint terrain manualy
   * chose places for trees by marking them via terrain leaves texture
   * create flow lines via sand/mood texture
   * create flow lines via stronger grass textures
4) create splines for roads via our R.A.M
   * R.A.M will automaticly paint and reshape terrain
   * adjust alpha of the road via vertex painter at road connections and just make more noise
5) setup bigger models and point of the interest in the middle od the scene
6) plant foliage manualy
   * put higher  forest trees in the middle
   * create forest wall from small and standalone trees
   * plant small bushes on forest border and randomly inside it
   * paint grass and flowers in relation to ground textures. More dry area less grass etc.
   * create forest/tree lines
7) Place few medium objects like rocks, trunks
8) spawn all small detail objects via Gena. 
9) we create fences by our own unreleased tool.
10) all detail objects are instanced in material (thats why they are so fast)
11) place reflection probes to get proper pbr in forest area and inside the meadow
12) place reflection probes so LOD's will get proper light... remember that at 2017.1 light probes 
break instancing and from 130 fps we get 30....In upper versions it will work fine. We will check it.
Thats why we turn them off for 2017.1 demo scene.
13) add background mountains
14) add post processing stack 2.0 and create profile
15) setup fog (take color from sky and adjust intensivity)

Note about grass:
Unity terrain doesn't support custom grass shaders that's why we use Vegetation Studio Pro in our video. 
Old Vegetation Studio could be used too or any other custom grass solution.

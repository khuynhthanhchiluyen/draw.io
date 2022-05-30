<mxfile host="app.diagrams.net" modified="2022-05-30T04:02:33.820Z" agent="5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/102.0.5005.61 Safari/537.36" etag="045cLZOUoH-vRkjY9wPq" version="17.4.5" type="github">
  <diagram id="WKR2CBcPURUVk5Ql0UBu" name="Page-1">
    <mxGraphModel dx="1355" dy="773" grid="1" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="1" pageScale="1" pageWidth="850" pageHeight="1100" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />
        <mxCell id="5RZST2oDJp6qAdW-rerX-4" value="cashservice" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="320" y="260" width="100" height="270" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-5" value="silkgate" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="540" y="260" width="80" height="70" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-6" value="isocias" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="540" y="440" width="80" height="70" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-7" value="h2h" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="540" y="350" width="80" height="70" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-8" value="client" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="60" y="340" width="80" height="70" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-9" value="hold" style="endArrow=classic;html=1;rounded=0;edgeStyle=orthogonalEdgeStyle;entryX=-0.006;entryY=0.113;entryDx=0;entryDy=0;entryPerimeter=0;exitX=0.5;exitY=0;exitDx=0;exitDy=0;startArrow=none;startFill=0;endFill=1;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-8" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="390" y="450" as="sourcePoint" />
            <mxPoint x="440" y="400" as="targetPoint" />
            <Array as="points">
              <mxPoint x="100" y="291" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-11" value="unhold" style="endArrow=classic;html=1;rounded=0;edgeStyle=orthogonalEdgeStyle;entryX=0;entryY=0.222;entryDx=0;entryDy=0;entryPerimeter=0;exitX=0.75;exitY=0;exitDx=0;exitDy=0;startArrow=none;startFill=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-8" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="110" y="350" as="sourcePoint" />
            <mxPoint x="329.4000000000001" y="300.51" as="targetPoint" />
            <Array as="points">
              <mxPoint x="120" y="320" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-14" value="cutonhold" style="endArrow=classic;html=1;rounded=0;edgeStyle=orthogonalEdgeStyle;exitX=1;exitY=0.25;exitDx=0;exitDy=0;entryX=-0.006;entryY=0.316;entryDx=0;entryDy=0;entryPerimeter=0;dashed=1;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-8" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="320" y="370" as="sourcePoint" />
            <mxPoint x="370" y="320" as="targetPoint" />
            <Array as="points">
              <mxPoint x="190" y="358" />
              <mxPoint x="190" y="345" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-17" value="kafka&lt;br&gt;&lt;font style=&quot;font-size: 6px&quot;&gt;(notify.cs.trans)&lt;/font&gt;" style="strokeWidth=2;html=1;shape=mxgraph.flowchart.direct_data;whiteSpace=wrap;" vertex="1" parent="1">
          <mxGeometry x="200" y="180" width="100" height="40" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-18" value="" style="endArrow=classic;html=1;rounded=0;entryX=1;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;edgeStyle=orthogonalEdgeStyle;curved=1;exitX=0.55;exitY=-0.001;exitDx=0;exitDy=0;exitPerimeter=0;dashed=1;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-4" target="5RZST2oDJp6qAdW-rerX-17">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="360" y="260" as="sourcePoint" />
            <mxPoint x="410" y="210" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-19" value="" style="endArrow=none;html=1;rounded=0;dashed=1;fontSize=6;curved=1;startArrow=classic;startFill=1;endFill=0;entryX=-0.018;entryY=0.612;entryDx=0;entryDy=0;entryPerimeter=0;edgeStyle=orthogonalEdgeStyle;exitX=0;exitY=0.571;exitDx=0;exitDy=0;exitPerimeter=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-8" target="5RZST2oDJp6qAdW-rerX-17">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="90" y="260" as="sourcePoint" />
            <mxPoint x="140" y="210" as="targetPoint" />
            <Array as="points">
              <mxPoint x="20" y="380" />
              <mxPoint x="20" y="220" />
              <mxPoint x="198" y="220" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-20" value="&lt;font size=&quot;1&quot;&gt;disburse&lt;/font&gt;" style="endArrow=classic;html=1;rounded=0;fontSize=6;curved=1;exitX=1;exitY=0.75;exitDx=0;exitDy=0;entryX=-0.003;entryY=0.488;entryDx=0;entryDy=0;entryPerimeter=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-8" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="240" y="400" as="sourcePoint" />
            <mxPoint x="290" y="350" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-21" value="derivative" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="230" y="610" width="80" height="70" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-22" value="capital" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="330" y="610" width="80" height="70" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-23" value="isave" style="rounded=0;whiteSpace=wrap;html=1;" vertex="1" parent="1">
          <mxGeometry x="425" y="610" width="80" height="70" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-24" value="" style="endArrow=none;startArrow=classic;html=1;rounded=0;fontSize=12;edgeStyle=elbowEdgeStyle;entryX=-0.003;entryY=0.962;entryDx=0;entryDy=0;entryPerimeter=0;exitX=0.5;exitY=0;exitDx=0;exitDy=0;endFill=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-21" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="300" y="560" as="sourcePoint" />
            <mxPoint x="350" y="510" as="targetPoint" />
            <Array as="points">
              <mxPoint x="270" y="580" />
              <mxPoint x="230" y="560" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-25" value="" style="endArrow=none;startArrow=classic;html=1;rounded=0;fontSize=12;edgeStyle=elbowEdgeStyle;entryX=0.5;entryY=1;entryDx=0;entryDy=0;exitX=0.5;exitY=0;exitDx=0;exitDy=0;startFill=1;endFill=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-22" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="240" y="620" as="sourcePoint" />
            <mxPoint x="330.20000000000005" y="513.8100000000001" as="targetPoint" />
            <Array as="points">
              <mxPoint x="370" y="570" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-26" value="" style="endArrow=none;startArrow=classic;html=1;rounded=0;fontSize=12;edgeStyle=elbowEdgeStyle;exitX=0.5;exitY=0;exitDx=0;exitDy=0;endFill=0;entryX=0.998;entryY=0.963;entryDx=0;entryDy=0;entryPerimeter=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-23" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="380" y="620" as="sourcePoint" />
            <mxPoint x="420" y="500" as="targetPoint" />
            <Array as="points">
              <mxPoint x="465" y="560" />
              <mxPoint x="510" y="560" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-27" value="&lt;font style=&quot;font-size: 10px&quot;&gt;transfer&lt;/font&gt;" style="endArrow=classic;html=1;rounded=0;fontSize=12;edgeStyle=elbowEdgeStyle;entryX=-0.006;entryY=0.626;entryDx=0;entryDy=0;exitX=0.75;exitY=1;exitDx=0;exitDy=0;entryPerimeter=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-8" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="310" y="530" as="sourcePoint" />
            <mxPoint x="360" y="480" as="targetPoint" />
            <Array as="points">
              <mxPoint x="120" y="430" />
              <mxPoint x="200" y="420" />
              <mxPoint x="250" y="460" />
              <mxPoint x="120" y="440" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-28" value="IA" style="endArrow=classic;startArrow=classic;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=0.996;exitY=0.104;exitDx=0;exitDy=0;exitPerimeter=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="419.60000000000014" y="274.08000000000004" as="sourcePoint" />
            <mxPoint x="540" y="273.5" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-29" value="repayment" style="endArrow=none;startArrow=classic;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=0.996;exitY=0.104;exitDx=0;exitDy=0;exitPerimeter=0;endFill=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="419.60000000000014" y="320.58000000000004" as="sourcePoint" />
            <mxPoint x="540" y="320" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-30" value="IA" style="endArrow=classic;startArrow=classic;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=0.996;exitY=0.104;exitDx=0;exitDy=0;exitPerimeter=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="420.0000000000001" y="451.28999999999996" as="sourcePoint" />
            <mxPoint x="540.4" y="450.71000000000004" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-31" value="repayment" style="endArrow=none;startArrow=classic;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=0.996;exitY=0.104;exitDx=0;exitDy=0;exitPerimeter=0;endFill=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="420.0000000000001" y="490.5799999999999" as="sourcePoint" />
            <mxPoint x="540.4" y="490" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-32" value="disburse" style="endArrow=classic;startArrow=none;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=0.996;exitY=0.104;exitDx=0;exitDy=0;exitPerimeter=0;endFill=1;startFill=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="419.60000000000014" y="295.29" as="sourcePoint" />
            <mxPoint x="540" y="294.71" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-33" value="disburse" style="endArrow=classic;startArrow=none;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=0.996;exitY=0.104;exitDx=0;exitDy=0;exitPerimeter=0;endFill=1;startFill=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="419.60000000000014" y="470.5799999999999" as="sourcePoint" />
            <mxPoint x="540" y="470" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-34" value="disburse" style="endArrow=classic;startArrow=none;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.25;entryDx=0;entryDy=0;exitX=0.996;exitY=0.104;exitDx=0;exitDy=0;exitPerimeter=0;endFill=1;startFill=0;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="420.0000000000001" y="384.5799999999999" as="sourcePoint" />
            <mxPoint x="540.4" y="384" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-35" value="complex-biz" style="endArrow=classic;html=1;rounded=0;fontSize=10;entryX=0.016;entryY=0.801;entryDx=0;entryDy=0;entryPerimeter=0;edgeStyle=orthogonalEdgeStyle;exitX=0.5;exitY=1;exitDx=0;exitDy=0;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-8" target="5RZST2oDJp6qAdW-rerX-4">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="120" y="500" as="sourcePoint" />
            <mxPoint x="170" y="450" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-39" value="TCB" style="rounded=0;whiteSpace=wrap;html=1;fontSize=10;" vertex="1" parent="1">
          <mxGeometry x="670" y="270" width="120" height="150" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-40" value="CTG" style="rounded=0;whiteSpace=wrap;html=1;fontSize=10;" vertex="1" parent="1">
          <mxGeometry x="700" y="430" width="60" height="50" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-41" value="" style="endArrow=classic;html=1;rounded=0;fontSize=10;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=-0.003;entryY=0.234;entryDx=0;entryDy=0;entryPerimeter=0;startArrow=classic;startFill=1;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-5">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="620" y="360" as="sourcePoint" />
            <mxPoint x="669.6399999999999" y="295.1" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-42" value="" style="endArrow=classic;html=1;rounded=0;fontSize=10;exitX=1;exitY=0.5;exitDx=0;exitDy=0;entryX=-0.003;entryY=0.234;entryDx=0;entryDy=0;entryPerimeter=0;startArrow=classic;startFill=1;" edge="1" parent="1">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="620.36" y="384.9" as="sourcePoint" />
            <mxPoint x="669.9999999999999" y="385" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-43" value="BIDV" style="rounded=0;whiteSpace=wrap;html=1;fontSize=10;" vertex="1" parent="1">
          <mxGeometry x="700" y="490" width="60" height="50" as="geometry" />
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-44" value="" style="endArrow=classic;startArrow=classic;html=1;rounded=0;fontSize=10;entryX=0.001;entryY=0.547;entryDx=0;entryDy=0;exitX=1;exitY=0.25;exitDx=0;exitDy=0;entryPerimeter=0;edgeStyle=elbowEdgeStyle;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-6" target="5RZST2oDJp6qAdW-rerX-40">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="620" y="490" as="sourcePoint" />
            <mxPoint x="670" y="440" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="5RZST2oDJp6qAdW-rerX-45" value="" style="endArrow=classic;startArrow=classic;html=1;rounded=0;fontSize=10;entryX=0;entryY=0.5;entryDx=0;entryDy=0;exitX=1;exitY=0.75;exitDx=0;exitDy=0;edgeStyle=elbowEdgeStyle;" edge="1" parent="1" source="5RZST2oDJp6qAdW-rerX-6" target="5RZST2oDJp6qAdW-rerX-43">
          <mxGeometry width="50" height="50" relative="1" as="geometry">
            <mxPoint x="629.9999999999999" y="467.5" as="sourcePoint" />
            <mxPoint x="710.06" y="467.35" as="targetPoint" />
          </mxGeometry>
        </mxCell>
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>

<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<TwitterPart>" %>

<div class="uc">
	<h2><%=Model.Title%></h2>

	<script src="http://widgets.twimg.com/j/2/widget.js"></script>
	<script type="text/javascript">
	//<![CDATA[
		new TWTR.Widget({
			version: 2,
			type: 'profile',
			rpp: 4,
			interval: 6000,
			width: '100%',
			height: 300,
			theme: {
				shell: {
					background: '#333333',
					color: '#ffffff'
				},
				tweets: {
					background: '#fff',
					color: '#000',
					links: '#33f'
				}
			},
			features: {
				scrollbar: false,
				loop: false,
				live: false,
				hashtags: true,
				timestamp: true,
				avatars: false,
				behavior: 'all'
			}
		}).render().setUser('<%=Model.UserName %>').start(); 
	//]]>
	</script>
</div>
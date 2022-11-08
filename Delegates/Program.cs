using Delegates;

var video = new Video() { Title = "Video 1" };
var videoEncoder = new VideoEncoder();
var mailService = new MailService();
var messageService = new MessageService();

//We register the handlers
videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

videoEncoder.Encode(video);